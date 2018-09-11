<!-- datatype -->
## PublishedDataSetDataType
This Structure DataType represents the PublishedDataSet parameters. The PublishedDataSetDataType is formally defined in Table 9.  
<!-- end of description -->
The fields of the PublishedDataSetDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|PublishedDataSetDataType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;name|[String](../../../Part3/DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;dataSetFolder|[String](../../../Part3/DataTypes/String/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;dataSetMetaData|[DataSetMetaDataType](../../../Part14/DataTypes/DataSetMetaDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;extensionFields|[KeyValuePair](../../../Part5/DataTypes/KeyValuePair/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;dataSetSource|[Structure](../../../Part3/DataTypes/Structure/readme.md)||

The representation of the PublishedDataSetDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15578|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|PublishedDataSetDataType|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part14|

