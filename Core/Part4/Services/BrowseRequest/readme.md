<!-- datatype -->
## BrowseRequest
Browse the references for one or more nodes from the server address space.  
<!-- end of description -->
The fields of the BrowseRequest DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|BrowseRequest|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;requestHeader|[RequestHeader](../../../Part4/Services/RequestHeader/readme.md)|A standard header included in all requests sent to a server.|
|&nbsp;&nbsp;&nbsp;&nbsp;view|[ViewDescription](../../../Part4/Services/ViewDescription/readme.md)|The view to browse.|
|&nbsp;&nbsp;&nbsp;&nbsp;requestedMaxReferencesPerNode|[Counter](../../../Part4/DataTypes/Counter/readme.md)|The maximum number of references to return in the response.|
|&nbsp;&nbsp;&nbsp;&nbsp;nodesToBrowse|[BrowseDescription](../../../Part4/Services/BrowseDescription/readme.md)[]|The list of nodes to browse.|

The representation of the BrowseRequest DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=525|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|BrowseRequest|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part4/Services|

