<!-- datatype -->
## MdnsDiscoveryConfiguration
The discovery information needed for mDNS registration.  
<!-- end of description -->
The fields of the MdnsDiscoveryConfiguration DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|MdnsDiscoveryConfiguration|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;mdnsServerName|[String](../../../Part3/DataTypes/String/readme.md)|The name for server that is broadcast via mDNS.|
|&nbsp;&nbsp;&nbsp;&nbsp;serverCapabilities|[String](../../../Part3/DataTypes/String/readme.md)[]|The server capabilities that are broadcast via mDNS.|

The representation of the MdnsDiscoveryConfiguration DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=12891|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|MdnsDiscoveryConfiguration|
|IsAbstract|False|
|BaseType|[DiscoveryConfiguration](../../../Part4/DataTypes/DiscoveryConfiguration/readme.md)|
|Categories|Part4|

