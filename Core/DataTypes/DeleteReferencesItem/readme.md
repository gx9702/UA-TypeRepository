<!-- datatype -->
## DeleteReferencesItem
A request to delete a node from the server address space.  
<!-- end of description -->
The fields of the DeleteReferencesItem DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|DeleteReferencesItem|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;sourceNodeId|[NodeId](../../DataTypes/NodeId/readme.md)|The source of the reference to delete.|
|&nbsp;&nbsp;&nbsp;&nbsp;referenceTypeId|[NodeId](../../DataTypes/NodeId/readme.md)|The type of reference to delete.|
|&nbsp;&nbsp;&nbsp;&nbsp;isForward|[Boolean](../../DataTypes/Boolean/readme.md)|If TRUE the a forward reference is deleted.|
|&nbsp;&nbsp;&nbsp;&nbsp;targetNodeId|[ExpandedNodeId](../../DataTypes/ExpandedNodeId/readme.md)|The target of the reference to delete.|
|&nbsp;&nbsp;&nbsp;&nbsp;deleteBidirectional|[Boolean](../../DataTypes/Boolean/readme.md)|If TRUE the reference is deleted in both directions.|

The representation of the DeleteReferencesItem DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=385|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|DeleteReferencesItem|
|IsAbstract|False|
|BaseType|[Structure](../../DataTypes/Structure/readme.md)|
|Categories||

