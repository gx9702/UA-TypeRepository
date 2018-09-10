<!-- datatype -->
## DeleteReferencesItem
A request to delete a node from the server address space.  
<!-- end of description -->
The fields of the DeleteReferencesItem DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|DeleteReferencesItem|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;sourceNodeId|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)|The source of the reference to delete.|
|&nbsp;&nbsp;&nbsp;&nbsp;referenceTypeId|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)|The type of reference to delete.|
|&nbsp;&nbsp;&nbsp;&nbsp;isForward|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)|If TRUE the a forward reference is deleted.|
|&nbsp;&nbsp;&nbsp;&nbsp;targetNodeId|[ExpandedNodeId](../../../Part4/DataTypes/ExpandedNodeId/readme.md)|The target of the reference to delete.|
|&nbsp;&nbsp;&nbsp;&nbsp;deleteBidirectional|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)|If TRUE the reference is deleted in both directions.|

The representation of the DeleteReferencesItem DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|DeleteReferencesItem|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

