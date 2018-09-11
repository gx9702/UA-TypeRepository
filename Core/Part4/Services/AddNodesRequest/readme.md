<!-- datatype -->
## AddNodesRequest
Adds one or more nodes to the server address space.  
<!-- end of description -->
The fields of the AddNodesRequest DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|AddNodesRequest|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;requestHeader|[RequestHeader](../../../Part4/Services/RequestHeader/readme.md)|A standard header included in all requests sent to a server.|
|&nbsp;&nbsp;&nbsp;&nbsp;nodesToAdd|[AddNodesItem](../../../Part4/DataTypes/AddNodesItem/readme.md)[]|The list of nodes to add.|

The representation of the AddNodesRequest DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=486|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|AddNodesRequest|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part4/Services|

