<!-- datatype -->
## PubSubGroupDataType
  
<!-- end of description -->
The fields of the PubSubGroupDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|PubSubGroupDataType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;name|[String](../../DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;enabled|[Boolean](../../DataTypes/Boolean/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;securityMode|[MessageSecurityMode](../../DataTypes/MessageSecurityMode/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;securityGroupId|[String](../../DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;securityKeyServices|[EndpointDescription](../../DataTypes/EndpointDescription/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;maxNetworkMessageSize|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;groupProperties|[KeyValuePair](../../DataTypes/KeyValuePair/readme.md)[]||

The representation of the PubSubGroupDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15609|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|PubSubGroupDataType|
|IsAbstract|True|
|BaseType|[Structure](../../DataTypes/Structure/readme.md)|
|Categories||

The references from the PubSubGroupDataType DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|DataType|WriterGroupDataType||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|DataType|ReaderGroupDataType||||

