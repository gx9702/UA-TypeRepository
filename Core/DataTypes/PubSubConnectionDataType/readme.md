<!-- datatype -->
## PubSubConnectionDataType
  
<!-- end of description -->
The fields of the PubSubConnectionDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|PubSubConnectionDataType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;name|[String](../../DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;enabled|[Boolean](../../DataTypes/Boolean/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;publisherId|[BaseDataType](../../DataTypes/BaseDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;transportProfileUri|[String](../../DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;address|[Structure](../../DataTypes/Structure/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;connectionProperties|[KeyValuePair](../../DataTypes/KeyValuePair/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;transportSettings|[Structure](../../DataTypes/Structure/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;writerGroups|[WriterGroupDataType](../../DataTypes/WriterGroupDataType/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;readerGroups|[ReaderGroupDataType](../../DataTypes/ReaderGroupDataType/readme.md)[]||

The representation of the PubSubConnectionDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15617|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|PubSubConnectionDataType|
|IsAbstract|False|
|BaseType|[Structure](../../DataTypes/Structure/readme.md)|
|Categories||

