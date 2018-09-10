<!-- datatype -->
## UadpDataSetReaderMessageDataType
<!-- end of description -->
The fields of the UadpDataSetReaderMessageDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|UadpDataSetReaderMessageDataType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;groupVersion|[VersionTime](../../../Part4/DataTypes/VersionTime/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;networkMessageNumber|[UInt16](../../../Part3/DataTypes/UInt16/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;dataSetOffset|[UInt16](../../../Part3/DataTypes/UInt16/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;dataSetClassId|[Guid](../../../Part3/DataTypes/Guid/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;networkMessageContentMask|[UadpNetworkMessageContentMask](../../../Part14/DataTypes/UadpNetworkMessageContentMask/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;dataSetMessageContentMask|[UadpDataSetMessageContentMask](../../../Part14/DataTypes/UadpDataSetMessageContentMask/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;publishingInterval|[Duration](../../../Part3/DataTypes/Duration/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;receiveOffset|[Duration](../../../Part3/DataTypes/Duration/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;processingOffset|[Duration](../../../Part3/DataTypes/Duration/readme.md)||

The representation of the UadpDataSetReaderMessageDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|UadpDataSetReaderMessageDataType|
|IsAbtract|False|
|BaseType|[DataSetReaderMessageDataType](../../../Part14/DataTypes/DataSetReaderMessageDataType/readme.md)|

