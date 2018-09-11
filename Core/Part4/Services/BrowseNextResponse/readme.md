<!-- datatype -->
## BrowseNextResponse
Continues one or more browse operations.  
<!-- end of description -->
The fields of the BrowseNextResponse DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|BrowseNextResponse|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;responseHeader|[ResponseHeader](../../../Part4/Services/ResponseHeader/readme.md)|A standard header included in all responses returned by servers.|
|&nbsp;&nbsp;&nbsp;&nbsp;results|[BrowseResult](../../../Part4/Services/BrowseResult/readme.md)[]|The results for the browse operations.|
|&nbsp;&nbsp;&nbsp;&nbsp;diagnosticInfos|[DiagnosticInfo](../../../Part4/DataTypes/DiagnosticInfo/readme.md)[]|The diagnostics associated with the results.|

The representation of the BrowseNextResponse DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=534|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|BrowseNextResponse|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part4/Services|

