<!-- datatype -->
## AddNodesItem
A request to add a node to the server address space.  
<!-- end of description -->
The fields of the AddNodesItem DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|AddNodesItem|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;parentNodeId|[ExpandedNodeId](../../DataTypes/ExpandedNodeId/readme.md)|The node id for the parent node.|
|&nbsp;&nbsp;&nbsp;&nbsp;referenceTypeId|[NodeId](../../DataTypes/NodeId/readme.md)|The type of reference from the parent to the new node.|
|&nbsp;&nbsp;&nbsp;&nbsp;requestedNewNodeId|[ExpandedNodeId](../../DataTypes/ExpandedNodeId/readme.md)|The node id requested by the client. If null the server must provide one.|
|&nbsp;&nbsp;&nbsp;&nbsp;browseName|[QualifiedName](../../DataTypes/QualifiedName/readme.md)|The browse name for the new node.|
|&nbsp;&nbsp;&nbsp;&nbsp;nodeClass|[NodeClass](../../DataTypes/NodeClass/readme.md)|The class of the new node.|
|&nbsp;&nbsp;&nbsp;&nbsp;nodeAttributes|[Structure](../../DataTypes/Structure/readme.md)|The default attributes for the new node.|
|&nbsp;&nbsp;&nbsp;&nbsp;typeDefinition|[ExpandedNodeId](../../DataTypes/ExpandedNodeId/readme.md)|The type definition for the new node.|

The representation of the AddNodesItem DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=376|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|AddNodesItem|
|IsAbstract|False|
|BaseType|[Structure](../../DataTypes/Structure/readme.md)|
|Categories||

