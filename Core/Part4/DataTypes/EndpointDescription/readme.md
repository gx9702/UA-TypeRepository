<!-- datatype -->
## EndpointDescription
<!-- end of description -->
The fields of the EndpointDescription DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|EndpointDescription|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;endpointUrl|[String](../../../Part3/DataTypes/String/readme.md)|The network endpoint to use when connecting to the server.|
|&nbsp;&nbsp;&nbsp;&nbsp;server|[ApplicationDescription](../../../Part4/DataTypes/ApplicationDescription/readme.md)|The description of the server.|
|&nbsp;&nbsp;&nbsp;&nbsp;serverCertificate|[ApplicationInstanceCertificate](../../../Part4/DataTypes/ApplicationInstanceCertificate/readme.md)|The server's application certificate.|
|&nbsp;&nbsp;&nbsp;&nbsp;securityMode|[MessageSecurityMode](../../../Part4/DataTypes/MessageSecurityMode/readme.md)|The security mode that must be used when connecting to the endpoint.|
|&nbsp;&nbsp;&nbsp;&nbsp;securityPolicyUri|[String](../../../Part3/DataTypes/String/readme.md)|The security policy to use when connecting to the endpoint.|
|&nbsp;&nbsp;&nbsp;&nbsp;userIdentityTokens|[UserTokenPolicy](../../../Part4/DataTypes/UserTokenPolicy/readme.md)[]|The user identity tokens that can be used with this endpoint.|
|&nbsp;&nbsp;&nbsp;&nbsp;transportProfileUri|[String](../../../Part3/DataTypes/String/readme.md)|The transport profile to use when connecting to the endpoint.|
|&nbsp;&nbsp;&nbsp;&nbsp;securityLevel|[Byte](../../../Part3/DataTypes/Byte/readme.md)|A server assigned value that indicates how secure the endpoint is relative to other server endpoints.|

The representation of the EndpointDescription DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|EndpointDescription|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

