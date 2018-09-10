<!-- datatype -->
## DeleteReferencesResponse
Delete one or more references from the server address space.  
<!-- end of description -->
The fields of the DeleteReferencesResponse DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|DeleteReferencesResponse|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;responseHeader|[ResponseHeader](../../../Part4/Services/ResponseHeader/readme.md)|A standard header included in all responses returned by servers.|
|&nbsp;&nbsp;&nbsp;&nbsp;results|[StatusCode](../../../Part4/DataTypes/StatusCode/readme.md)[]|The results for the delete reference operations.|
|&nbsp;&nbsp;&nbsp;&nbsp;diagnosticInfos|[DiagnosticInfo](../../../Part4/DataTypes/DiagnosticInfo/readme.md)[]|The diagnostics associated with the results returned.|

The representation of the DeleteReferencesResponse DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|DeleteReferencesResponse|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

