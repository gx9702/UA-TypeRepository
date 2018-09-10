<!-- datatype -->
## ActivateSessionResponse
Activates a session with the server.  
<!-- end of description -->
The fields of the ActivateSessionResponse DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|ActivateSessionResponse|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;responseHeader|[ResponseHeader](../../../Part4/Services/ResponseHeader/readme.md)|A standard header included in all responses returned by servers.|
|&nbsp;&nbsp;&nbsp;&nbsp;serverNonce|[ByteString](../../../Part3/DataTypes/ByteString/readme.md)|A random number generated by the server.|
|&nbsp;&nbsp;&nbsp;&nbsp;results|[StatusCode](../../../Part4/DataTypes/StatusCode/readme.md)[]|Any errors during validation of the software certificates.|
|&nbsp;&nbsp;&nbsp;&nbsp;diagnosticInfos|[DiagnosticInfo](../../../Part4/DataTypes/DiagnosticInfo/readme.md)[]|The diagnostics associated with the software certificates results.|

The representation of the ActivateSessionResponse DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|ActivateSessionResponse|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
