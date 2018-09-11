<!-- datatype -->
## TranslateBrowsePathsToNodeIdsResponse
Translates one or more paths in the server address space.  
<!-- end of description -->
The fields of the TranslateBrowsePathsToNodeIdsResponse DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|TranslateBrowsePathsToNodeIdsResponse|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;responseHeader|[ResponseHeader](../../../Part4/Services/ResponseHeader/readme.md)|A standard header included in all responses returned by servers.|
|&nbsp;&nbsp;&nbsp;&nbsp;results|[BrowsePathResult](../../../Part4/Services/BrowsePathResult/readme.md)[]|The results for the translate operations.|
|&nbsp;&nbsp;&nbsp;&nbsp;diagnosticInfos|[DiagnosticInfo](../../../Part4/DataTypes/DiagnosticInfo/readme.md)[]|The diagnostics associated with the results.|

The representation of the TranslateBrowsePathsToNodeIdsResponse DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=555|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|TranslateBrowsePathsToNodeIdsResponse|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part4/Services|

