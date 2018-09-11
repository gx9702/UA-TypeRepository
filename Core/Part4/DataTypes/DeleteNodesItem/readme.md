<!-- datatype -->
## DeleteNodesItem
A request to delete a node to the server address space.  
<!-- end of description -->
The fields of the DeleteNodesItem DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|DeleteNodesItem|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;nodeId|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)|The id of the node to delete.|
|&nbsp;&nbsp;&nbsp;&nbsp;deleteTargetReferences|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)|If TRUE all references to the are deleted as well.|

The representation of the DeleteNodesItem DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=382|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|DeleteNodesItem|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part4|

