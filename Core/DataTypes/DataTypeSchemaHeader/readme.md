<!-- datatype -->
## DataTypeSchemaHeader
  
<!-- end of description -->
The fields of the DataTypeSchemaHeader DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|DataTypeSchemaHeader|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;namespaces|[String](../../DataTypes/String/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;structureDataTypes|[StructureDescription](../../DataTypes/StructureDescription/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;enumDataTypes|[EnumDescription](../../DataTypes/EnumDescription/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;simpleDataTypes|[SimpleTypeDescription](../../DataTypes/SimpleTypeDescription/readme.md)[]||

The representation of the DataTypeSchemaHeader DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15534|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|DataTypeSchemaHeader|
|IsAbstract|True|
|BaseType|[Structure](../../DataTypes/Structure/readme.md)|
|Categories||

The references from the DataTypeSchemaHeader DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|DataType|UABinaryFileDataType||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|DataType|DataSetMetaDataType||||

