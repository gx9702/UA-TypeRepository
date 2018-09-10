<!-- objecttype -->
## AuditAddNodesEventType
The representation of the AuditAddNodesEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|AuditAddNodesEventType|
|NodeClass|ObjectType|
|IsAbtract|True|
|BaseType|[AuditNodeManagementEventType](../../../Part5/ObjectTypes/AuditNodeManagementEventType/readme.md)|

The references from the AuditAddNodesEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|NodesToAdd|[AddNodesItem](../../../Part4/DataTypes/AddNodesItem/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

