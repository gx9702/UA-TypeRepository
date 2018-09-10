<!-- datatype -->
## DeleteNodesResponse
<!-- end of description -->
The fields of the DeleteNodesResponse DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|DeleteNodesResponse|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;responseHeader|[ResponseHeader](../../../Part4/Services/ResponseHeader/readme.md)|A standard header included in all responses returned by servers.|
|&nbsp;&nbsp;&nbsp;&nbsp;results|[StatusCode](../../../Part4/DataTypes/StatusCode/readme.md)[]|The results for the delete nodes operations.|
|&nbsp;&nbsp;&nbsp;&nbsp;diagnosticInfos|[DiagnosticInfo](../../../Part4/DataTypes/DiagnosticInfo/readme.md)[]|The diagnostics associated with the results returned.|

The representation of the DeleteNodesResponse DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|DeleteNodesResponse|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

