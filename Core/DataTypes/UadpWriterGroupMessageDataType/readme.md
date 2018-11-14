<!-- datatype -->
## UadpWriterGroupMessageDataType
  
<!-- end of description -->
The fields of the UadpWriterGroupMessageDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|UadpWriterGroupMessageDataType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;groupVersion|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;dataSetOrdering|[DataSetOrderingType](../../DataTypes/DataSetOrderingType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;networkMessageContentMask|[UadpNetworkMessageContentMask](../../DataTypes/UadpNetworkMessageContentMask/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;samplingOffset|[Duration](../../DataTypes/Duration/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;publishingOffset|[Duration](../../DataTypes/Duration/readme.md)[]||

The representation of the UadpWriterGroupMessageDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15645|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|UadpWriterGroupMessageDataType|
|IsAbstract|False|
|BaseType|[WriterGroupMessageDataType](../../DataTypes/WriterGroupMessageDataType/readme.md)|
|Categories||

