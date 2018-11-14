<!-- datatype -->
## WriterGroupDataType
  
<!-- end of description -->
The fields of the WriterGroupDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|WriterGroupDataType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;writerGroupId|[UInt16](../../DataTypes/UInt16/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;publishingInterval|[Duration](../../DataTypes/Duration/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;keepAliveTime|[Duration](../../DataTypes/Duration/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;priority|[Byte](../../DataTypes/Byte/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;localeIds|[LocaleId](../../DataTypes/LocaleId/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;headerLayoutUri|[String](../../DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;transportSettings|[Structure](../../DataTypes/Structure/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;messageSettings|[Structure](../../DataTypes/Structure/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;dataSetWriters|[DataSetWriterDataType](../../DataTypes/DataSetWriterDataType/readme.md)[]||

The representation of the WriterGroupDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15480|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|WriterGroupDataType|
|IsAbstract|False|
|BaseType|[PubSubGroupDataType](../../DataTypes/PubSubGroupDataType/readme.md)|
|Categories||

