using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Markdig;

namespace MarkdownProcessor
{
    internal class Settings
    {
        public bool OutputMarkdown;
        public string OutputPath;
        public string TargetModel;
        public Dictionary<string,string> NodeSetFiles;
        public Dictionary<string, string> RepositoryPaths;

        public static class ArgName
        {
            public const string Markdown = "-markdown";
            public const string Output = "-output=";
            public const string Model = "-model=";
        }

        public static void ShowUsage()
        {
            Console.WriteLine("MarkdownProcessor [-markdown|-word|-nodeset] -output=<path> -model=<namespace-uri>,<nodeset-location>,<repository-path>");
            Console.WriteLine("");
            Console.WriteLine("where");
            Console.WriteLine("   -markdown specifies a markdown repository is created/updated at the output location.");
            Console.WriteLine("   -nodeset specifies that the nodeset if updated with the text from a markdown repository.");
            Console.WriteLine("   -word specifies that the nodeset is used to update a word document.");
            Console.WriteLine("");
            Console.WriteLine("   -model specifies the URI and nodeset file location and a optional repository path. The location may be a URL.");
            Console.WriteLine("          If the repository path is not provided it is assumed the nodeset is at the root of the repository.");
            Console.WriteLine("          The model parameter may be specified multiple times when there are dependencies.");
            Console.WriteLine("          The first model parameter is the primary nodeset.");
            Console.WriteLine("");
            Console.WriteLine("   -output specifies a local directory or file path (depends on what the operation needs).");
        }

        public static Settings Parse(string[] args)
        {
            Settings settings = new Settings();

            settings.OutputMarkdown = false;
            settings.OutputPath = ".\\";
            settings.TargetModel = null;
            settings.NodeSetFiles = new Dictionary<string, string>();
            settings.RepositoryPaths = new Dictionary<string, string>();

            foreach (var arg in args)
            {
                if (arg == ArgName.Markdown)
                {
                    settings.OutputMarkdown = true;
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

        static void Main(string[] args)
        {
            Settings = Settings.Parse(args);

            if (Settings == null)
            {
                return;
            }

            if (Settings.OutputMarkdown)
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
                Console.ReadLine();
                return;
            }
        }

        private static void ModelImporter_ModelRequired(object sender, ModelRequiredEventArgs e)
        {
            string nodeSetPath = null;

            if (Settings.NodeSetFiles.TryGetValue(e.ModelUri, out nodeSetPath))
            {
                e.ModelFilePath = nodeSetPath;
            }

            string repositoryPath = null;

            if (!Settings.RepositoryPaths.TryGetValue(e.ModelUri, out repositoryPath))
            {
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

                e.ModelLinkPath = repositoryPath;
            }

            e.ModelLinkPath = repositoryPath;
        }
    }
}



/*
ModelImporter importer = new ModelImporter();
importer.ModelRequired += ModelImporter_ModelRequired;
importer.LoadModel("Opc.Ua.Adi.NodeSet2.xml");

var repository1 = importer.CreateRepository("http://opcfoundation.org/UA/");

string root = @"X:\Work\OPC\UA-TypeRepository2\Core";

if (Directory.Exists(root))
{
    Directory.Delete(root, true);
}

MarkdownExporter exporter = new MarkdownExporter();
exporter.Export(repository1, root);

var repository2 = importer.CreateRepository("http://opcfoundation.org/UA/DI/");

root = @"X:\Work\OPC\UA-TypeRepository\DI";

if (Directory.Exists(root))
{
    Directory.Delete(root, true);
}

exporter.Export(repository2, root);

var repository3 = importer.CreateRepository("http://opcfoundation.org/UA/ADI/");

root = @"X:\Work\OPC\UA-TypeRepository\ADI";

if (Directory.Exists(root))
{
    Directory.Delete(root, true);
}

exporter.Export(repository3, root);

MarkdownImporter importer2 = new MarkdownImporter();
var repository = importer2.Import(null, root);

importer.MergeRepository("http://opcfoundation.org/UA/ADI/", repository);
*/
