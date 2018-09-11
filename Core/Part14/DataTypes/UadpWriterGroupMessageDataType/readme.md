<!-- datatype -->
## UadpWriterGroupMessageDataType
  
<!-- end of description -->
The fields of the UadpWriterGroupMessageDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|UadpWriterGroupMessageDataType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;groupVersion|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;dataSetOrdering|[DataSetOrderingType](../../../Part14/DataTypes/DataSetOrderingType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;networkMessageContentMask|[UadpNetworkMessageContentMask](../../../Part14/DataTypes/UadpNetworkMessageContentMask/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;samplingOffset|[Duration](../../../Part3/DataTypes/Duration/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;publishingOffset|[Duration](../../../Part3/DataTypes/Duration/readme.md)[]||

The representation of the UadpWriterGroupMessageDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15645|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|UadpWriterGroupMessageDataType|
|IsAbstract|False|
|BaseType|[WriterGroupMessageDataType](../../../Part14/DataTypes/WriterGroupMessageDataType/readme.md)|
|Categories|Part14|

