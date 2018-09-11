<!-- datatype -->
## DeleteNodesRequest
Delete one or more nodes from the server address space.  
<!-- end of description -->
The fields of the DeleteNodesRequest DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|DeleteNodesRequest|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;requestHeader|[RequestHeader](../../../Part4/Services/RequestHeader/readme.md)|A standard header included in all requests sent to a server.|
|&nbsp;&nbsp;&nbsp;&nbsp;nodesToDelete|[DeleteNodesItem](../../../Part4/DataTypes/DeleteNodesItem/readme.md)[]|The list of nodes to delete.|

The representation of the DeleteNodesRequest DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=498|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|DeleteNodesRequest|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part4/Services|

