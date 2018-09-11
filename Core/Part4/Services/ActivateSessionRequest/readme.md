<!-- datatype -->
## ActivateSessionRequest
Activates a session with the server.  
<!-- end of description -->
The fields of the ActivateSessionRequest DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|ActivateSessionRequest|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;requestHeader|[RequestHeader](../../../Part4/Services/RequestHeader/readme.md)|A standard header included in all requests sent to a server.|
|&nbsp;&nbsp;&nbsp;&nbsp;clientSignature|[SignatureData](../../../Part4/Services/SignatureData/readme.md)|A signature created with the client certificate from the last server nonce returned by the server.|
|&nbsp;&nbsp;&nbsp;&nbsp;clientSoftwareCertificates|[SignedSoftwareCertificate](../../../Part4/DataTypes/SignedSoftwareCertificate/readme.md)[]|The software certificates owned by the client.|
|&nbsp;&nbsp;&nbsp;&nbsp;localeIds|[LocaleId](../../../Part3/DataTypes/LocaleId/readme.md)[]|The locales to use with the session.|
|&nbsp;&nbsp;&nbsp;&nbsp;userIdentityToken|[Structure](../../../Part3/DataTypes/Structure/readme.md)|The user identity to use with the session.|
|&nbsp;&nbsp;&nbsp;&nbsp;userTokenSignature|[SignatureData](../../../Part4/Services/SignatureData/readme.md)|A digital signature created with the user identity token.|

The representation of the ActivateSessionRequest DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=465|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|ActivateSessionRequest|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part4/Services|

