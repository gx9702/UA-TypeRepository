<!-- datatype -->
## ReferenceNode
Specifies a reference which belongs to a node.  
<!-- end of description -->
The fields of the ReferenceNode DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|ReferenceNode|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;referenceTypeId|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)|The node id of the reference type for the reference.|
|&nbsp;&nbsp;&nbsp;&nbsp;isInverse|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)|The reference is an inverse reference.|
|&nbsp;&nbsp;&nbsp;&nbsp;targetId|[ExpandedNodeId](../../../Part4/DataTypes/ExpandedNodeId/readme.md)|The node id for the target of the reference.|

The representation of the ReferenceNode DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|ReferenceNode|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

