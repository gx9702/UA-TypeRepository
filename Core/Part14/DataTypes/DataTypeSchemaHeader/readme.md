<!-- datatype -->
## DataTypeSchemaHeader
This Structure DataType is the abstract base type used to provide OPC UA DataType definitions for an OPC UA Binary encoded byte blob used outside an OPC UA Server AddressSpace.

 The DataTypeSchemaHeader is formally defined in Table A.1.  
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
|NodeId|i=15534|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|DataTypeSchemaHeader|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part14|

The references from the DataTypeSchemaHeader DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|UABinaryFileDataType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|DataSetMetaDataType||||

