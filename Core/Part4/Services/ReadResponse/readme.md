<!-- datatype -->
## ReadResponse
  
<!-- end of description -->
The fields of the ReadResponse DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|ReadResponse|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;responseHeader|[ResponseHeader](../../../Part4/Services/ResponseHeader/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;results|[DataValue](../../../Part4/DataTypes/DataValue/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;diagnosticInfos|[DiagnosticInfo](../../../Part4/DataTypes/DiagnosticInfo/readme.md)[]||

The representation of the ReadResponse DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=632|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|ReadResponse|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part4/Services|

