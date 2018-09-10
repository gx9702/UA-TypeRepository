<!-- datatype -->
## ChannelSecurityToken
<!-- end of description -->
The fields of the ChannelSecurityToken DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|ChannelSecurityToken|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;channelId|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)|A unique identifier for the channel.|
|&nbsp;&nbsp;&nbsp;&nbsp;tokenId|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)|A unique identifier for the current token.|
|&nbsp;&nbsp;&nbsp;&nbsp;createdAt|[UtcTime](../../../Part3/DataTypes/UtcTime/readme.md)|When the channel was created.|
|&nbsp;&nbsp;&nbsp;&nbsp;revisedLifetime|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)|When the channel will expiry.|

The representation of the ChannelSecurityToken DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|ChannelSecurityToken|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

