<!-- objecttype -->
## HierarchicalReferences
The abstract base type for all hierarchical references.  
<!-- end of text -->
The representation of the HierarchicalReferences ReferenceType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=33|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|HierarchicalReferences|
|NodeClass|ReferenceType|
|IsAbstract|True|
|BaseType|[References](../../../Part3/ReferenceTypes/References/readme.md)|
|Categories|Part3|

The references from the HierarchicalReferences ReferenceType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ReferenceType|[HasChild](#HasChild)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ReferenceType|[Organizes](#Organizes)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ReferenceType|[HasEventSource](#HasEventSource)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ReferenceType|[DataSetToWriter](#DataSetToWriter)||||


