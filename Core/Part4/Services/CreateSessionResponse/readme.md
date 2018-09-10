<!-- datatype -->
## CreateSessionResponse
Creates a new session with the server.  
<!-- end of description -->
The fields of the CreateSessionResponse DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|CreateSessionResponse|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;responseHeader|[ResponseHeader](../../../Part4/Services/ResponseHeader/readme.md)|A standard header included in all responses returned by servers.|
|&nbsp;&nbsp;&nbsp;&nbsp;sessionId|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)|A identifier which uniquely identifies the session.|
|&nbsp;&nbsp;&nbsp;&nbsp;authenticationToken|[SessionAuthenticationToken](../../../Part4/DataTypes/SessionAuthenticationToken/readme.md)|The token used to authenticate the client in subsequent requests.|
|&nbsp;&nbsp;&nbsp;&nbsp;revisedSessionTimeout|[Duration](../../../Part3/DataTypes/Duration/readme.md)|The session timeout in milliseconds.|
|&nbsp;&nbsp;&nbsp;&nbsp;serverNonce|[ByteString](../../../Part3/DataTypes/ByteString/readme.md)|A random number generated by the server.|
|&nbsp;&nbsp;&nbsp;&nbsp;serverCertificate|[ApplicationInstanceCertificate](../../../Part4/DataTypes/ApplicationInstanceCertificate/readme.md)|The application certificate for the server.|
|&nbsp;&nbsp;&nbsp;&nbsp;serverEndpoints|[EndpointDescription](../../../Part4/DataTypes/EndpointDescription/readme.md)[]|The endpoints provided by the server.|
|&nbsp;&nbsp;&nbsp;&nbsp;serverSoftwareCertificates|[SignedSoftwareCertificate](../../../Part4/DataTypes/SignedSoftwareCertificate/readme.md)[]|The software certificates owned by the server.|
|&nbsp;&nbsp;&nbsp;&nbsp;serverSignature|[SignatureData](../../../Part4/Services/SignatureData/readme.md)|A signature created with the server certificate.|
|&nbsp;&nbsp;&nbsp;&nbsp;maxRequestMessageSize|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)|The maximum message size accepted by the server.|

The representation of the CreateSessionResponse DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|CreateSessionResponse|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
