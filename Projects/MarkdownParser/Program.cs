using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Markdig;

namespace MarkdownProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            ModelImporter importer = new ModelImporter();
            importer.ModelRequired += ModelImporter_ModelRequired;
            importer.LoadModel("Opc.Ua.Adi.NodeSet2.xml");

            var repository1 = importer.CreateRepository("http://opcfoundation.org/UA/");

            string root = @"X:\Work\OPC\UA-TypeRepository\Core3";

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
            
            /*
            // Configure the pipeline with all advanced extensions active
            MarkdownDirectory directory = new MarkdownDirectory();
            directory.Import(@"X:\Work\OPC\UA-TypeRepository\Core2");

            // try
            {
                NodeSetExporter exporter = new NodeSetExporter();
                exporter.ModelRequired += Exporter_ModelRequired;

                exporter.LoadModel("Opc.Ua.Adi.NodeSet2.xml");

                exporter.Export("http://opcfoundation.org/UA/", @"X:\Work\OPC\UA-TypeRepository\Core\Temp");

                int x = 0;
            }
          //  catch (Exception e)
            {
                // Console.WriteLine(e.Message);
            }
            */
        }

        private static void ModelImporter_ModelRequired(object sender, ModelRequiredEventArgs e)
        {
            switch (e.ModelUri)
            {
                case "http://opcfoundation.org/UA/":
                {
                    e.ModelFilePath = "Opc.Ua.NodeSet2.xml";
                    e.ModelLinkPath = "../Core3";
                    break;
                }

                case "http://opcfoundation.org/UA/DI/":
                {
                    e.ModelFilePath = "Opc.Ua.Di.NodeSet2.xml";
                    e.ModelLinkPath = "../DI";
                    break;
                }

                case "http://opcfoundation.org/UA/ADI/":
                {
                    e.ModelFilePath = "Opc.Ua.Adi.NodeSet2.xml";
                    e.ModelLinkPath = "../ADI";
                    break;
                }
            }
        }
    }
}
