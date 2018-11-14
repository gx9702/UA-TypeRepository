<!-- datatype -->
## DataTypeDescription
  
<!-- end of description -->
The fields of the DataTypeDescription DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|DataTypeDescription|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;dataTypeId|[NodeId](../../DataTypes/NodeId/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;name|[QualifiedName](../../DataTypes/QualifiedName/readme.md)||

The representation of the DataTypeDescription DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=14525|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|DataTypeDescription|
|IsAbstract|True|
|BaseType|[Structure](../../DataTypes/Structure/readme.md)|
|Categories||

The references from the DataTypeDescription DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|DataType|StructureDescription||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|DataType|EnumDescription||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|DataType|SimpleTypeDescription||||

