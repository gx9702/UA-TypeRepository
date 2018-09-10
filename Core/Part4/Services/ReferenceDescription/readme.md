<!-- datatype -->
## ReferenceDescription
<!-- end of description -->
The fields of the ReferenceDescription DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|ReferenceDescription|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;referenceTypeId|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)|The type of references.|
|&nbsp;&nbsp;&nbsp;&nbsp;isForward|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)|TRUE if the reference is a forward reference.|
|&nbsp;&nbsp;&nbsp;&nbsp;nodeId|[ExpandedNodeId](../../../Part4/DataTypes/ExpandedNodeId/readme.md)|The id of the target node.|
|&nbsp;&nbsp;&nbsp;&nbsp;browseName|[QualifiedName](../../../Part3/DataTypes/QualifiedName/readme.md)|The browse name of the target node.|
|&nbsp;&nbsp;&nbsp;&nbsp;displayName|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)|The display name of the target node.|
|&nbsp;&nbsp;&nbsp;&nbsp;nodeClass|[NodeClass](../../../Part3/DataTypes/NodeClass/readme.md)|The node class of the target node.|
|&nbsp;&nbsp;&nbsp;&nbsp;typeDefinition|[ExpandedNodeId](../../../Part4/DataTypes/ExpandedNodeId/readme.md)|The type definition of the target node.|

The representation of the ReferenceDescription DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|ReferenceDescription|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

