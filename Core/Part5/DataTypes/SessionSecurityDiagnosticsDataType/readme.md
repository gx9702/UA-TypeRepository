<!-- datatype -->
## SessionSecurityDiagnosticsDataType
  
<!-- end of description -->
The fields of the SessionSecurityDiagnosticsDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|SessionSecurityDiagnosticsDataType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;sessionId|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;clientUserIdOfSession|[String](../../../Part3/DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;clientUserIdHistory|[String](../../../Part3/DataTypes/String/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;authenticationMechanism|[String](../../../Part3/DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;encoding|[String](../../../Part3/DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;transportProtocol|[String](../../../Part3/DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;securityMode|[MessageSecurityMode](../../../Part4/DataTypes/MessageSecurityMode/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;securityPolicyUri|[String](../../../Part3/DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;clientCertificate|[ByteString](../../../Part3/DataTypes/ByteString/readme.md)||

The representation of the SessionSecurityDiagnosticsDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=868|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|SessionSecurityDiagnosticsDataType|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part5|

