<!-- datatype -->
## ResponseHeader
The header passed with every server response.  
<!-- end of description -->
The fields of the ResponseHeader DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|ResponseHeader|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;timestamp|[UtcTime](../../../Part3/DataTypes/UtcTime/readme.md)|When the response was sent by the server.|
|&nbsp;&nbsp;&nbsp;&nbsp;requestHandle|[IntegerId](../../../Part4/DataTypes/IntegerId/readme.md)|The handle passed by the client in the request.|
|&nbsp;&nbsp;&nbsp;&nbsp;serviceResult|[StatusCode](../../../Part4/DataTypes/StatusCode/readme.md)|The result of the operation. If Bad there are no parameters returned.|
|&nbsp;&nbsp;&nbsp;&nbsp;serviceDiagnostics|[DiagnosticInfo](../../../Part4/DataTypes/DiagnosticInfo/readme.md)|The diagnostics associated with the ServiceResult.|
|&nbsp;&nbsp;&nbsp;&nbsp;stringTable|[String](../../../Part3/DataTypes/String/readme.md)[]|A table of strings referenced by the diagnotics structures included in the request.|
|&nbsp;&nbsp;&nbsp;&nbsp;additionalHeader|[Structure](../../../Part3/DataTypes/Structure/readme.md)|Allows vendor specific information to be included in the header.|

The representation of the ResponseHeader DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=392|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|ResponseHeader|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part4/Services|

