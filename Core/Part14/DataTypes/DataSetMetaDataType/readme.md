<!-- datatype -->
## DataSetMetaDataType
<!-- end of description -->
The fields of the DataSetMetaDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|DataSetMetaDataType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;name|[String](../../../Part3/DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;description|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;fields|[FieldMetaData](../../../Part14/DataTypes/FieldMetaData/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;dataSetClassId|[Guid](../../../Part3/DataTypes/Guid/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;configurationVersion|[ConfigurationVersionDataType](../../../Part14/DataTypes/ConfigurationVersionDataType/readme.md)||

The representation of the DataSetMetaDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|DataSetMetaDataType|
|IsAbtract|False|
|BaseType|[DataTypeSchemaHeader](../../../Part14/DataTypes/DataTypeSchemaHeader/readme.md)|

