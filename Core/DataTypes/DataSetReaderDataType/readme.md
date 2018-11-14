<!-- datatype -->
## DataSetReaderDataType
  
<!-- end of description -->
The fields of the DataSetReaderDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|DataSetReaderDataType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;name|[String](../../DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;enabled|[Boolean](../../DataTypes/Boolean/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;publisherId|[BaseDataType](../../DataTypes/BaseDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;writerGroupId|[UInt16](../../DataTypes/UInt16/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;dataSetWriterId|[UInt16](../../DataTypes/UInt16/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;dataSetMetaData|[DataSetMetaDataType](../../DataTypes/DataSetMetaDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;dataSetFieldContentMask|[DataSetFieldContentMask](../../DataTypes/DataSetFieldContentMask/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;messageReceiveTimeout|[Duration](../../DataTypes/Duration/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;keyFrameCount|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;headerLayoutUri|[String](../../DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;securityMode|[MessageSecurityMode](../../DataTypes/MessageSecurityMode/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;securityGroupId|[String](../../DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;securityKeyServices|[EndpointDescription](../../DataTypes/EndpointDescription/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;dataSetReaderProperties|[KeyValuePair](../../DataTypes/KeyValuePair/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;transportSettings|[Structure](../../DataTypes/Structure/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;messageSettings|[Structure](../../DataTypes/Structure/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;subscribedDataSet|[Structure](../../DataTypes/Structure/readme.md)||

The representation of the DataSetReaderDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15623|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|DataSetReaderDataType|
|IsAbstract|False|
|BaseType|[Structure](../../DataTypes/Structure/readme.md)|
|Categories||

