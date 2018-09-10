<!-- datatype -->
## AddNodesResponse
Adds one or more nodes to the server address space.  
<!-- end of description -->
The fields of the AddNodesResponse DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|AddNodesResponse|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;responseHeader|[ResponseHeader](../../../Part4/Services/ResponseHeader/readme.md)|A standard header included in all responses returned by servers.|
|&nbsp;&nbsp;&nbsp;&nbsp;results|[AddNodesResult](../../../Part4/Services/AddNodesResult/readme.md)[]|The results for the add node operations.|
|&nbsp;&nbsp;&nbsp;&nbsp;diagnosticInfos|[DiagnosticInfo](../../../Part4/DataTypes/DiagnosticInfo/readme.md)[]|The diagnostics associated with the results returned.|

The representation of the AddNodesResponse DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|AddNodesResponse|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

