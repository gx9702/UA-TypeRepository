<!-- datatype -->
## TranslateBrowsePathsToNodeIdsRequest
Translates one or more paths in the server address space.  
<!-- end of description -->
The fields of the TranslateBrowsePathsToNodeIdsRequest DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|TranslateBrowsePathsToNodeIdsRequest|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;requestHeader|[RequestHeader](../../../Part4/Services/RequestHeader/readme.md)|A standard header included in all requests sent to a server.|
|&nbsp;&nbsp;&nbsp;&nbsp;browsePaths|[BrowsePath](../../../Part4/Services/BrowsePath/readme.md)[]|The list of paths to translate.|

The representation of the TranslateBrowsePathsToNodeIdsRequest DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=552|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|TranslateBrowsePathsToNodeIdsRequest|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part4/Services|

