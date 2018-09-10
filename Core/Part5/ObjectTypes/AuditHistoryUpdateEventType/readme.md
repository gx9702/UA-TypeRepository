<!-- objecttype -->
## AuditHistoryUpdateEventType
The representation of the AuditHistoryUpdateEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|AuditHistoryUpdateEventType|
|NodeClass|ObjectType|
|IsAbtract|True|
|BaseType|[AuditUpdateEventType](../../../Part5/ObjectTypes/AuditUpdateEventType/readme.md)|

The references from the AuditHistoryUpdateEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|ParameterDataTypeId||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|AuditHistoryEventUpdateEventType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|AuditHistoryValueUpdateEventType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|AuditHistoryDeleteEventType||||

