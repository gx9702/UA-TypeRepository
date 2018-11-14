<!-- datatype -->
## DataSetMetaDataType
  
<!-- end of description -->
The fields of the DataSetMetaDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|DataSetMetaDataType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;name|[String](../../DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;description|[LocalizedText](../../DataTypes/LocalizedText/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;fields|[FieldMetaData](../../DataTypes/FieldMetaData/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;dataSetClassId|[Guid](../../DataTypes/Guid/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;configurationVersion|[ConfigurationVersionDataType](../../DataTypes/ConfigurationVersionDataType/readme.md)||

The representation of the DataSetMetaDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=14523|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|DataSetMetaDataType|
|IsAbstract|False|
|BaseType|[DataTypeSchemaHeader](../../DataTypes/DataTypeSchemaHeader/readme.md)|
|Categories||

