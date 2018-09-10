<!-- datatype -->
## PubSubConnectionDataType
<!-- end of description -->
The fields of the PubSubConnectionDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|PubSubConnectionDataType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;name|[String](../../../Part3/DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;enabled|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;publisherId|[BaseDataType](../../../Part3/DataTypes/BaseDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;transportProfileUri|[String](../../../Part3/DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;address|[Structure](../../../Part3/DataTypes/Structure/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;connectionProperties|[KeyValuePair](../../../Part5/DataTypes/KeyValuePair/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;transportSettings|[Structure](../../../Part3/DataTypes/Structure/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;writerGroups|[WriterGroupDataType](../../../Part14/DataTypes/WriterGroupDataType/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;readerGroups|[ReaderGroupDataType](../../../Part14/DataTypes/ReaderGroupDataType/readme.md)[]||

The representation of the PubSubConnectionDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|PubSubConnectionDataType|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

