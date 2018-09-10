<!-- objecttype -->
## AuditHistoryDeleteEventType
The representation of the AuditHistoryDeleteEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|AuditHistoryDeleteEventType|
|NodeClass|ObjectType|
|IsAbtract|True|
|BaseType|[AuditHistoryUpdateEventType](../../../Part5/ObjectTypes/AuditHistoryUpdateEventType/readme.md)|

The references from the AuditHistoryDeleteEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|UpdatedNode|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|AuditHistoryRawModifyDeleteEventType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|AuditHistoryAtTimeDeleteEventType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|AuditHistoryEventDeleteEventType||||

