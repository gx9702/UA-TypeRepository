<!-- datatype -->
## RequestHeader
<!-- end of description -->
The fields of the RequestHeader DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|RequestHeader|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;authenticationToken|[SessionAuthenticationToken](../../../Part4/DataTypes/SessionAuthenticationToken/readme.md)|The authentication token for the current session.|
|&nbsp;&nbsp;&nbsp;&nbsp;timestamp|[UtcTime](../../../Part3/DataTypes/UtcTime/readme.md)|When the request was sent by the client.|
|&nbsp;&nbsp;&nbsp;&nbsp;requestHandle|[IntegerId](../../../Part4/DataTypes/IntegerId/readme.md)|A handle assigned by the client to the request. It is returned in the response.|
|&nbsp;&nbsp;&nbsp;&nbsp;returnDiagnostics|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)|A mask indicating what diagnostic information should be returned in the response.|
|&nbsp;&nbsp;&nbsp;&nbsp;auditEntryId|[String](../../../Part3/DataTypes/String/readme.md)|Identifies an entry in the client audit log.|
|&nbsp;&nbsp;&nbsp;&nbsp;timeoutHint|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)|The timeout for the operation specified by the client.|
|&nbsp;&nbsp;&nbsp;&nbsp;additionalHeader|[Structure](../../../Part3/DataTypes/Structure/readme.md)|Allows vendor specific information to be included in the header.|

The representation of the RequestHeader DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|RequestHeader|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

