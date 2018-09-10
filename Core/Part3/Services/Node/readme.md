<!-- datatype -->
## Node
Specifies the attributes which belong to all nodes.  
<!-- end of description -->
The fields of the Node DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|Node|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;nodeId|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)|A unique identifier for the node.|
|&nbsp;&nbsp;&nbsp;&nbsp;nodeClass|[NodeClass](../../../Part3/DataTypes/NodeClass/readme.md)|The class of the node.|
|&nbsp;&nbsp;&nbsp;&nbsp;browseName|[QualifiedName](../../../Part3/DataTypes/QualifiedName/readme.md)|The browse name of the node.|
|&nbsp;&nbsp;&nbsp;&nbsp;displayName|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)|The display name of the node.|
|&nbsp;&nbsp;&nbsp;&nbsp;description|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)|The description of the node.|
|&nbsp;&nbsp;&nbsp;&nbsp;writeMask|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)|A mask indicating which attributes are writable.|
|&nbsp;&nbsp;&nbsp;&nbsp;userWriteMask|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)|A mask indicating which attributes are writable by the current user.|
|&nbsp;&nbsp;&nbsp;&nbsp;rolePermissions|[RolePermissionType](../../../Part3/DataTypes/RolePermissionType/readme.md)[]|A list of permissions for the node assigned to roles.|
|&nbsp;&nbsp;&nbsp;&nbsp;userRolePermissions|[RolePermissionType](../../../Part3/DataTypes/RolePermissionType/readme.md)[]|A list of permissions for the node assigned to roles which are available to the current session.|
|&nbsp;&nbsp;&nbsp;&nbsp;accessRestrictions|[UInt16](../../../Part3/DataTypes/UInt16/readme.md)|A mask indicating any access restrictions that apply to the node.|
|&nbsp;&nbsp;&nbsp;&nbsp;references|[ReferenceNode](../../../Part3/Services/ReferenceNode/readme.md)[]|The references that belong to the node.|

The representation of the Node DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|Node|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

The references from the Node DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|InstanceNode||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|TypeNode||||

