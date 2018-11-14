<!-- datatype -->
## EndpointDescription
The description of a endpoint that can be used to access a server.  
<!-- end of description -->
The fields of the EndpointDescription DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|EndpointDescription|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;endpointUrl|[String](../../DataTypes/String/readme.md)|The network endpoint to use when connecting to the server.|
|&nbsp;&nbsp;&nbsp;&nbsp;server|[ApplicationDescription](../../DataTypes/ApplicationDescription/readme.md)|The description of the server.|
|&nbsp;&nbsp;&nbsp;&nbsp;serverCertificate|[ApplicationInstanceCertificate](../../DataTypes/ApplicationInstanceCertificate/readme.md)|The server's application certificate.|
|&nbsp;&nbsp;&nbsp;&nbsp;securityMode|[MessageSecurityMode](../../DataTypes/MessageSecurityMode/readme.md)|The security mode that must be used when connecting to the endpoint.|
|&nbsp;&nbsp;&nbsp;&nbsp;securityPolicyUri|[String](../../DataTypes/String/readme.md)|The security policy to use when connecting to the endpoint.|
|&nbsp;&nbsp;&nbsp;&nbsp;userIdentityTokens|[UserTokenPolicy](../../DataTypes/UserTokenPolicy/readme.md)[]|The user identity tokens that can be used with this endpoint.|
|&nbsp;&nbsp;&nbsp;&nbsp;transportProfileUri|[String](../../DataTypes/String/readme.md)|The transport profile to use when connecting to the endpoint.|
|&nbsp;&nbsp;&nbsp;&nbsp;securityLevel|[Byte](../../DataTypes/Byte/readme.md)|A server assigned value that indicates how secure the endpoint is relative to other server endpoints.|

The representation of the EndpointDescription DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=312|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|EndpointDescription|
|IsAbstract|False|
|BaseType|[Structure](../../DataTypes/Structure/readme.md)|
|Categories||

