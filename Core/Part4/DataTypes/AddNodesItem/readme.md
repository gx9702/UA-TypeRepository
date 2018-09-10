<!-- datatype -->
## AddNodesItem
<!-- end of description -->
The fields of the AddNodesItem DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|AddNodesItem|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;parentNodeId|[ExpandedNodeId](../../../Part4/DataTypes/ExpandedNodeId/readme.md)|The node id for the parent node.|
|&nbsp;&nbsp;&nbsp;&nbsp;referenceTypeId|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)|The type of reference from the parent to the new node.|
|&nbsp;&nbsp;&nbsp;&nbsp;requestedNewNodeId|[ExpandedNodeId](../../../Part4/DataTypes/ExpandedNodeId/readme.md)|The node id requested by the client. If null the server must provide one.|
|&nbsp;&nbsp;&nbsp;&nbsp;browseName|[QualifiedName](../../../Part3/DataTypes/QualifiedName/readme.md)|The browse name for the new node.|
|&nbsp;&nbsp;&nbsp;&nbsp;nodeClass|[NodeClass](../../../Part3/DataTypes/NodeClass/readme.md)|The class of the new node.|
|&nbsp;&nbsp;&nbsp;&nbsp;nodeAttributes|[Structure](../../../Part3/DataTypes/Structure/readme.md)|The default attributes for the new node.|
|&nbsp;&nbsp;&nbsp;&nbsp;typeDefinition|[ExpandedNodeId](../../../Part4/DataTypes/ExpandedNodeId/readme.md)|The type definition for the new node.|

The representation of the AddNodesItem DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|AddNodesItem|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

