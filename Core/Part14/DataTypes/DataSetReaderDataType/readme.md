<!-- datatype -->
## DataSetReaderDataType
This Structure DataType is used to represent the DataSetReader parameters. The DataSetReaderDataType is formally defined in Table 36.  
<!-- end of description -->
The fields of the DataSetReaderDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|DataSetReaderDataType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;name|[String](../../../Part3/DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;enabled|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;publisherId|[BaseDataType](../../../Part3/DataTypes/BaseDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;writerGroupId|[UInt16](../../../Part3/DataTypes/UInt16/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;dataSetWriterId|[UInt16](../../../Part3/DataTypes/UInt16/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;dataSetMetaData|[DataSetMetaDataType](../../../Part14/DataTypes/DataSetMetaDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;dataSetFieldContentMask|[DataSetFieldContentMask](../../../Part14/DataTypes/DataSetFieldContentMask/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;messageReceiveTimeout|[Duration](../../../Part3/DataTypes/Duration/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;securityMode|[MessageSecurityMode](../../../Part4/DataTypes/MessageSecurityMode/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;securityGroupId|[String](../../../Part3/DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;securityKeyServices|[EndpointDescription](../../../Part4/DataTypes/EndpointDescription/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;dataSetReaderProperties|[KeyValuePair](../../../Part5/DataTypes/KeyValuePair/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;transportSettings|[Structure](../../../Part3/DataTypes/Structure/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;messageSettings|[Structure](../../../Part3/DataTypes/Structure/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;subscribedDataSet|[Structure](../../../Part3/DataTypes/Structure/readme.md)||

The representation of the DataSetReaderDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15623|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|DataSetReaderDataType|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part14|

