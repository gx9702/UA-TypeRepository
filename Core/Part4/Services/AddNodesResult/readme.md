<!-- datatype -->
## AddNodesResult
A result of an add node operation.  
<!-- end of description -->
The fields of the AddNodesResult DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|AddNodesResult|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;statusCode|[StatusCode](../../../Part4/DataTypes/StatusCode/readme.md)|A code indicating any error during the operation.|
|&nbsp;&nbsp;&nbsp;&nbsp;addedNodeId|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)|The id of the new node.|

The representation of the AddNodesResult DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=483|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|AddNodesResult|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part4/Services|

