<!-- objecttype -->
## AuditDeleteNodesEventType
The representation of the AuditDeleteNodesEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|AuditDeleteNodesEventType|
|NodeClass|ObjectType|
|IsAbtract|True|
|BaseType|[AuditNodeManagementEventType](../../../Part5/ObjectTypes/AuditNodeManagementEventType/readme.md)|

The references from the AuditDeleteNodesEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|NodesToDelete|[DeleteNodesItem](../../../Part4/DataTypes/DeleteNodesItem/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

