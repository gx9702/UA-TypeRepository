<!-- datatype -->
## DataSetMetaDataType
This Structure DataType is a subtype of DataTypeSchemaHeader and is used to provide the metadata for a DataSet. The DataSetMetaDataType is formally defined in Table 3.

The DataTypeSchemaHeader provides OPC UA DataType definitions used in the DataSetMetaData. The DataTypeSchemaHeader is defined in A.1.1.  
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
|NodeId|i=14523|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|DataSetMetaDataType|
|IsAbstract|False|
|BaseType|[DataTypeSchemaHeader](../../../Part14/DataTypes/DataTypeSchemaHeader/readme.md)|
|Categories|Part14|

