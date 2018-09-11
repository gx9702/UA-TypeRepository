<!-- datatype -->
## WriterGroupDataType
This Structure DataType is used to represent the configuration parameters for WriterGroups. It is a subtype of PubSubGroupDataType defined in 0.

The WriterGroupDataType is formally defined in Table 22.  
<!-- end of description -->
The fields of the WriterGroupDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|WriterGroupDataType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;writerGroupId|[UInt16](../../../Part3/DataTypes/UInt16/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;publishingInterval|[Duration](../../../Part3/DataTypes/Duration/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;keepAliveTime|[Duration](../../../Part3/DataTypes/Duration/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;priority|[Byte](../../../Part3/DataTypes/Byte/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;localeIds|[LocaleId](../../../Part3/DataTypes/LocaleId/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;transportSettings|[Structure](../../../Part3/DataTypes/Structure/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;messageSettings|[Structure](../../../Part3/DataTypes/Structure/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;dataSetWriters|[DataSetWriterDataType](../../../Part14/DataTypes/DataSetWriterDataType/readme.md)[]||

The representation of the WriterGroupDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15480|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|WriterGroupDataType|
|IsAbstract|False|
|BaseType|[PubSubGroupDataType](../../../Part14/DataTypes/PubSubGroupDataType/readme.md)|
|Categories|Part14|

