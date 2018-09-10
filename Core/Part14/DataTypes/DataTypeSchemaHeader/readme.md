<!-- datatype -->
## DataTypeSchemaHeader
<!-- end of description -->
The fields of the DataTypeSchemaHeader DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|DataTypeSchemaHeader|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;namespaces|[String](../../../Part3/DataTypes/String/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;structureDataTypes|[StructureDescription](../../../Part14/DataTypes/StructureDescription/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;enumDataTypes|[EnumDescription](../../../Part14/DataTypes/EnumDescription/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;simpleDataTypes|[SimpleTypeDescription](../../../Part14/DataTypes/SimpleTypeDescription/readme.md)[]||

The representation of the DataTypeSchemaHeader DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|DataTypeSchemaHeader|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

The references from the DataTypeSchemaHeader DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|UABinaryFileDataType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|DataSetMetaDataType||||

