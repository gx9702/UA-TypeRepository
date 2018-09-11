<!-- datatype -->
## HistoryUpdateResponse
  
<!-- end of description -->
The fields of the HistoryUpdateResponse DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|HistoryUpdateResponse|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;responseHeader|[ResponseHeader](../../../Part4/Services/ResponseHeader/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;results|[HistoryUpdateResult](../../../Part4/Services/HistoryUpdateResult/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;diagnosticInfos|[DiagnosticInfo](../../../Part4/DataTypes/DiagnosticInfo/readme.md)[]||

The representation of the HistoryUpdateResponse DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=701|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|HistoryUpdateResponse|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part4/Services|

