<!-- objecttype -->
## HasChild
The abstract base type for all non-looping hierarchical references.  
<!-- end of text -->
The representation of the HasChild ReferenceType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=34|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|HasChild|
|NodeClass|ReferenceType|
|IsAbstract|True|
|BaseType|[HierarchicalReferences](../../ReferenceTypes/HierarchicalReferences/readme.md)|
|Categories||

The references from the HasChild ReferenceType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ReferenceType|[Aggregates](#Aggregates)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ReferenceType|[HasSubtype](#HasSubtype)||||


