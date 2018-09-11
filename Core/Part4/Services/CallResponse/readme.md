<!-- datatype -->
## CallResponse
  
<!-- end of description -->
The fields of the CallResponse DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|CallResponse|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;responseHeader|[ResponseHeader](../../../Part4/Services/ResponseHeader/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;results|[CallMethodResult](../../../Part4/Services/CallMethodResult/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;diagnosticInfos|[DiagnosticInfo](../../../Part4/DataTypes/DiagnosticInfo/readme.md)[]||

The representation of the CallResponse DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=713|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|CallResponse|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part4/Services|

