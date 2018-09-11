using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Opc.Ua;
using MarkdownProcessor.NodeSet;

namespace MarkdownProcessor
{
    public class Repository : RepositoryIndex
    {
        public Dictionary<NodeId, string> SymbolNames;

        public Repository()
        {
            SymbolNames = new Dictionary<NodeId, string>();
        }
    }

    public class RepositoryEntry
    {
        public string Name;
        public RepositoryEntry Parent;

        public override string ToString()
        {
            return Name;
        }
    }

    public class RepositoryIndex : RepositoryEntry
    {
        public List<RepositoryEntry> Children;

        public RepositoryIndex()
        {
            Children = new List<RepositoryEntry>();
        }
    }

    public class RepositoryDefinition
    {
        public string Name;
        public List<string> Documentation;
        public List<string> Notes;

        public RepositoryDefinition()
        {
            Documentation = new List<string>();
            Notes = new List<string>();
        }
    }

    public class RepositoryDefinitionList : RepositoryEntry
    {
        public List<RepositoryDefinition> Children;

        public RepositoryDefinitionList()
        {
            Children = new List<RepositoryDefinition>();
        }
    }

    public class RepositoryLink
    {
        public string Name;
        public string Path;
    }

    public class RepositoryReference
    {
        public string BrowseName;
        public NodeClass NodeClass;
        public RepositoryLink DataType;
        public int ValueRank;
        public RepositoryLink ReferenceType;
        public RepositoryLink TypeDefinition;
        public RepositoryLink ModellingRule;
        public List<string> Documentation;
        public List<RepositoryDataTypeField> InputArguments;
        public List<RepositoryDataTypeField> OutputArguments;
        public List<RepositoryStatusCode> StatusCodes;

        public RepositoryReference()
        {
            Documentation = new List<string>();
            InputArguments = new List<RepositoryDataTypeField>();
            OutputArguments = new List<RepositoryDataTypeField>();
            StatusCodes = new List<RepositoryStatusCode>();
        }
    }
    public class RepositoryStatusCode
    {
        public string Code;
        public List<string> Documentation;

        public RepositoryStatusCode()
        {
            Documentation = new List<string>();
        }
    }

    public class RepositoryObjectVariableType : RepositoryEntry
    {
        public NodeId NodeId;
        public string NamespaceUri;
        public NodeClass NodeClass;
        public bool IsAbstract;
        public RepositoryLink DataType;
        public int ValueRank;
        public RepositoryLink BaseType;
        public List<RepositoryReference> References;
        public List<string> Documentation;
        public List<string> Categories;

        public RepositoryObjectVariableType()
        {
            References = new List<RepositoryReference>();
            Documentation = new List<string>();
            Categories = new List<string>();
        }
    }

    public class RepositoryDataTypeField
    {
        public string Name;
        public RepositoryLink DataType;
        public int ValueRank;
        public int Value;
        public bool IsOptional;
        public List<string> Documentation;

        public RepositoryDataTypeField()
        {
            Documentation = new List<string>();
        }
    };

    public enum DataTypeClass
    {
        Structure,
        Union,
        Enumeration,
        OptionSet
    }

    public class RepositoryDataType : RepositoryEntry
    {
        public NodeId NodeId;
        public string NamespaceUri;
        public bool IsAbstract;
        public DataTypeClass DataTypeClass;
        public RepositoryLink BaseType;
        public List<RepositoryDataTypeField> Fields;
        public List<RepositoryReference> References;
        public List<string> Documentation;
        public List<string> Categories;

        public RepositoryDataType()
        {
            DataTypeClass = DataTypeClass.Structure;
            Documentation = new List<string>();
            Categories = new List<string>();
            References = new List<RepositoryReference>();
            Fields = new List<RepositoryDataTypeField>();
        }
    }
}
