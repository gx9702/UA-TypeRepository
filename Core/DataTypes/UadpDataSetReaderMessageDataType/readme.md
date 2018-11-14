<!-- datatype -->
## UadpDataSetReaderMessageDataType
  
<!-- end of description -->
The fields of the UadpDataSetReaderMessageDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|UadpDataSetReaderMessageDataType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;groupVersion|[VersionTime](../../DataTypes/VersionTime/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;networkMessageNumber|[UInt16](../../DataTypes/UInt16/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;dataSetOffset|[UInt16](../../DataTypes/UInt16/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;dataSetClassId|[Guid](../../DataTypes/Guid/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;networkMessageContentMask|[UadpNetworkMessageContentMask](../../DataTypes/UadpNetworkMessageContentMask/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;dataSetMessageContentMask|[UadpDataSetMessageContentMask](../../DataTypes/UadpDataSetMessageContentMask/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;publishingInterval|[Duration](../../DataTypes/Duration/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;receiveOffset|[Duration](../../DataTypes/Duration/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;processingOffset|[Duration](../../DataTypes/Duration/readme.md)||

The representation of the UadpDataSetReaderMessageDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15653|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|UadpDataSetReaderMessageDataType|
|IsAbstract|False|
|BaseType|[DataSetReaderMessageDataType](../../DataTypes/DataSetReaderMessageDataType/readme.md)|
|Categories||

