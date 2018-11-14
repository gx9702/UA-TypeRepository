<!-- datatype -->
## AddReferencesItem
A request to add a reference to the server address space.  
<!-- end of description -->
The fields of the AddReferencesItem DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|AddReferencesItem|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;sourceNodeId|[NodeId](../../DataTypes/NodeId/readme.md)|The source of the reference.|
|&nbsp;&nbsp;&nbsp;&nbsp;referenceTypeId|[NodeId](../../DataTypes/NodeId/readme.md)|The type of reference.|
|&nbsp;&nbsp;&nbsp;&nbsp;isForward|[Boolean](../../DataTypes/Boolean/readme.md)|If TRUE the reference is a forward reference.|
|&nbsp;&nbsp;&nbsp;&nbsp;targetServerUri|[String](../../DataTypes/String/readme.md)|The URI of the server containing the target (if in another server).|
|&nbsp;&nbsp;&nbsp;&nbsp;targetNodeId|[ExpandedNodeId](../../DataTypes/ExpandedNodeId/readme.md)|The target of the reference.|
|&nbsp;&nbsp;&nbsp;&nbsp;targetNodeClass|[NodeClass](../../DataTypes/NodeClass/readme.md)|The node class of the target (if known).|

The representation of the AddReferencesItem DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=379|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|AddReferencesItem|
|IsAbstract|False|
|BaseType|[Structure](../../DataTypes/Structure/readme.md)|
|Categories||

