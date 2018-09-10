<!-- datatype -->
## PubSubGroupDataType
<!-- end of description -->
The fields of the PubSubGroupDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|PubSubGroupDataType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;name|[String](../../../Part3/DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;enabled|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;securityMode|[MessageSecurityMode](../../../Part4/DataTypes/MessageSecurityMode/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;securityGroupId|[String](../../../Part3/DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;securityKeyServices|[EndpointDescription](../../../Part4/DataTypes/EndpointDescription/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;maxNetworkMessageSize|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;groupProperties|[KeyValuePair](../../../Part5/DataTypes/KeyValuePair/readme.md)[]||

The representation of the PubSubGroupDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|PubSubGroupDataType|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

The references from the PubSubGroupDataType DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|WriterGroupDataType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|ReaderGroupDataType||||

