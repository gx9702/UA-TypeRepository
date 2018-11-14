using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Markdig;

namespace MarkdownProcessor
{
    internal enum Operation
    {
        NodeSetToMarkdown,
        MarkdownToNodeSet,
        WordToNodeSet,
        WordAnalysis
    }

    internal class Settings
    {
        public Operation Operation;
        public string OutputPath;
        public string InputPath;
        public string TargetModel;
        public Dictionary<string, string> NodeSetFiles;
        public Dictionary<string, string> RepositoryPaths;

        public static class ArgName
        {
            public const string WordDocumentAnalysis = "-word-analysis";
            public const string NodeSetToMarkdown = "-nodeset-to-markdown";
            public const string MarkdownToNodeSet = "-markdown-to-nodeset";
            public const string WordToNodeSet = "-word-to-nodeset";
            public const string Input = "-input=";
            public const string Output = "-output=";
            public const string Model = "-model=";
        }

        public static void ShowUsage()
        {
            Console.WriteLine("MarkdownProcessor [-nodeset-to-markdown|-markdown-to-nodeset|-word-to-nodeset] -input=<path> -output=<path> -model=<namespace-uri>,<nodeset-location>,<repository-path>");
            Console.WriteLine("");
            Console.WriteLine("where");
            Console.WriteLine("   -nodeset-to-markdown specifies a markdown repository is created/updated at the output location.");
            Console.WriteLine("   -markdown-to-nodeset specifies that the nodeset is updated with the text from a markdown repository.");
            Console.WriteLine("   -word-to-nodeset specifies that the nodeset is updated with the text from a word document.");
            Console.WriteLine("");
            Console.WriteLine("   -model specifies the URI and nodeset file location and a optional repository path. The location may be a URL.");
            Console.WriteLine("          If the repository path is not provided it is assumed the nodeset is at the root of the repository.");
            Console.WriteLine("          The model parameter may be specified multiple times when there are dependencies.");
            Console.WriteLine("          The first model parameter is the primary nodeset.");
            Console.WriteLine("");
            Console.WriteLine("   -output specifies a local directory or file path (depends on what the operation needs).");
            Console.WriteLine("   -input  specifies a local directory or file path (depends on what the operation needs).");
        }

        public static Settings Parse(string[] args)
        {
            Settings settings = new Settings();

            settings.Operation = Operation.NodeSetToMarkdown;
            settings.InputPath = null;
            settings.OutputPath = ".\\";
            settings.TargetModel = null;
            settings.NodeSetFiles = new Dictionary<string, string>();
            settings.RepositoryPaths = new Dictionary<string, string>();

            foreach (var arg in args)
            {
                bool processed = true;

                switch (arg)
                {
                    case ArgName.NodeSetToMarkdown: { settings.Operation = Operation.NodeSetToMarkdown; break; }
                    case ArgName.MarkdownToNodeSet: { settings.Operation = Operation.MarkdownToNodeSet; break; }
                    case ArgName.WordToNodeSet: { settings.Operation = Operation.WordToNodeSet; break; }
                    case ArgName.WordDocumentAnalysis: { settings.Operation = Operation.WordAnalysis; break; }
                    default: { processed = false; break; }
                }

                if (processed)
                {
                    continue;
                }

                if (arg.StartsWith(ArgName.Input))
                {
                    settings.InputPath = arg.Substring(ArgName.Input.Length);
                    continue;
                }

                if (arg.StartsWith(ArgName.Output))
                {
                    settings.OutputPath = arg.Substring(ArgName.Output.Length);
                    continue;
                }

                if (arg.StartsWith(ArgName.Model))
                {
                    var value = arg.Substring(ArgName.Model.Length);
                    var filePaths = value.Split(',');

                    if (filePaths.Length < 2 || String.IsNullOrEmpty(filePaths[0]) || String.IsNullOrEmpty(filePaths[1]))
                    {
                        Console.WriteLine($"ERROR - Argument is invalid: {arg}");
                        ShowUsage();
                        return null;
                    }

                    settings.NodeSetFiles[filePaths[0]] = filePaths[1];

                    if (settings.TargetModel == null)
                    {
                        settings.TargetModel = filePaths[0];
                    }

                    if (filePaths.Length == 3)
                    {
                        if (String.IsNullOrEmpty(filePaths[2]))
                        {
                            Console.WriteLine($"ERROR - Argument is invalid: {arg}");
                            ShowUsage();
                            return null;
                        }

                        settings.RepositoryPaths[filePaths[0]] = filePaths[2];
                        continue;
                    }

                    continue;
                }

                Console.WriteLine($"ERROR - Argument is unknown: {arg}");
                ShowUsage();
                return null;
            }

            return settings;
        }
    }

    class Program
    {
        static Settings Settings;

        [STAThread]
        static void Main(string[] args)
        {
            Settings = Settings.Parse(args);

            if (Settings == null)
            {
                return;
            }

            if (Settings.Operation == Operation.WordAnalysis)
            {
                Console.WriteLine($"Merge Word Document: {Settings.InputPath}");
                WordImporter importer = new WordImporter();
                importer.Analyze(Settings.InputPath, @"X:\Work\OPC\UA-TypeRepository2\Core\IECTemplate.docx", Settings.OutputPath);
            }

            if (Settings.Operation == Operation.WordToNodeSet)
            {
                Console.WriteLine($"Loading Model: {Settings.TargetModel}");
                ModelImporter importer = new ModelImporter();
                importer.ModelRequired += ModelImporter_ModelRequired;
                importer.LoadModel(Settings.NodeSetFiles[Settings.TargetModel]);

                Console.WriteLine($"Merge Word Document: {Settings.InputPath}");
                importer.MergeWordDocument(Settings.TargetModel, Settings.InputPath);

                Console.WriteLine($"Save NodeSet: {Settings.OutputPath}");
                importer.SaveNodeSet(Settings.TargetModel, Settings.OutputPath);

                Console.WriteLine($"All Done!");
                return;
            }

            if (Settings.Operation == Operation.NodeSetToMarkdown)
            {
                Console.WriteLine($"Loading Model: {Settings.TargetModel}");
                ModelImporter importer = new ModelImporter();
                importer.ModelRequired += ModelImporter_ModelRequired;
                importer.LoadModel(Settings.NodeSetFiles[Settings.TargetModel]);

                Console.WriteLine($"Creating Repository: {Settings.TargetModel}");
                var repository = importer.CreateRepository(Settings.TargetModel);

                Console.WriteLine($"Deleting Output Directory: {Settings.OutputPath}");

                if (Directory.Exists(Settings.OutputPath))
                {
                    foreach (var child in Directory.EnumerateDirectories(Settings.OutputPath))
                    {
                        Directory.Delete(child, true);
                    }
                }

                Console.WriteLine($"Exporting Markdown: {Settings.OutputPath}");
                MarkdownExporter exporter = new MarkdownExporter();
                exporter.Export(repository, Settings.OutputPath);

                Console.WriteLine($"All Done!");
                return;
            }

            if (Settings.Operation == Operation.MarkdownToNodeSet)
            {
                Console.WriteLine($"Loading Model: {Settings.TargetModel}");
                ModelImporter importer = new ModelImporter();
                importer.ModelRequired += ModelImporter_ModelRequired;
                importer.LoadModel(Settings.NodeSetFiles[Settings.TargetModel]);

                var repositoryPath = GetRepositoryPath(Settings.TargetModel);
                Console.WriteLine($"Loading Markdown: {repositoryPath}");
                MarkdownImporter markdown = new MarkdownImporter();
                var repository = markdown.Import(repositoryPath);

                Console.WriteLine($"Merge Markdown");
                importer.MergeRepository(Settings.TargetModel, repository);

                Console.WriteLine($"Save NodeSet: {Settings.OutputPath}");
                importer.SaveNodeSet(Settings.TargetModel, Settings.OutputPath);
                
                Console.WriteLine($"All Done!");
                return;
            }
        }

        private static string GetRepositoryPath(string modelUri)
        {
            string repositoryPath = null;

            if (!Settings.RepositoryPaths.TryGetValue(modelUri, out repositoryPath))
            {
                string nodeSetPath = null;

                if (!Settings.NodeSetFiles.TryGetValue(modelUri, out nodeSetPath))
                {
                    return null;
                }

                repositoryPath = nodeSetPath;

                int index = repositoryPath.LastIndexOfAny(new char[] { '/', '\\' });

                if (index < 0)
                {
                    repositoryPath = "./";
                }
                else
                {
                    repositoryPath = repositoryPath.Substring(0, index);
                }
            }

            return repositoryPath;
        }

        private static void ModelImporter_ModelRequired(object sender, ModelRequiredEventArgs e)
        {
            string nodeSetPath = null;

            if (Settings.NodeSetFiles.TryGetValue(e.ModelUri, out nodeSetPath))
            {
                e.ModelFilePath = nodeSetPath;
            }

            string repositoryPath = GetRepositoryPath(e.ModelUri);

            if (repositoryPath != null && e.ModelUri != Settings.TargetModel)
            {
                string targetPath = GetRepositoryPath(Settings.TargetModel);

                DirectoryInfo path1 = new DirectoryInfo(repositoryPath);
                DirectoryInfo path2 = new DirectoryInfo(targetPath);

                string relativePath = "";

                while (path2 != null)
                {
                    if (!path1.FullName.StartsWith(path2.FullName))
                    {
                        relativePath += "..\\";
                        path2 = path2.Parent;
                        continue;
                    }

                    relativePath = $"{relativePath}{path1.FullName.Substring(path2.FullName.Length+1)}";
                    break;
                }

                repositoryPath = relativePath.Replace("\\", "/");
            }

            e.ModelLinkPath = repositoryPath;
        }
    }
}

