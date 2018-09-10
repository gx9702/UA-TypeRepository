<!-- objecttype -->
## AuditHistoryValueUpdateEventType
The representation of the AuditHistoryValueUpdateEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|AuditHistoryValueUpdateEventType|
|NodeClass|ObjectType|
|IsAbtract|True|
|BaseType|[AuditHistoryUpdateEventType](../../../Part5/ObjectTypes/AuditHistoryUpdateEventType/readme.md)|

The references from the AuditHistoryValueUpdateEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|UpdatedNode||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|PerformInsertReplace||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|NewValues||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|OldValues||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

