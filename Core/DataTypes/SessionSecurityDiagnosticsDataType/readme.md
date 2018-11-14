<!-- datatype -->
## SessionSecurityDiagnosticsDataType
  
<!-- end of description -->
The fields of the SessionSecurityDiagnosticsDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|SessionSecurityDiagnosticsDataType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;sessionId|[NodeId](../../DataTypes/NodeId/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;clientUserIdOfSession|[String](../../DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;clientUserIdHistory|[String](../../DataTypes/String/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;authenticationMechanism|[String](../../DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;encoding|[String](../../DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;transportProtocol|[String](../../DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;securityMode|[MessageSecurityMode](../../DataTypes/MessageSecurityMode/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;securityPolicyUri|[String](../../DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;clientCertificate|[ByteString](../../DataTypes/ByteString/readme.md)||

The representation of the SessionSecurityDiagnosticsDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=868|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|SessionSecurityDiagnosticsDataType|
|IsAbstract|False|
|BaseType|[Structure](../../DataTypes/Structure/readme.md)|
|Categories||

