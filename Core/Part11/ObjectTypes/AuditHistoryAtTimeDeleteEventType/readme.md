<!-- objecttype -->
## AuditHistoryAtTimeDeleteEventType

The representation of the AuditHistoryAtTimeDeleteEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|AuditHistoryAtTimeDeleteEventType|
|NodeClass|ObjectType|
|IsAbtract|True|
|BaseType|[AuditHistoryDeleteEventType](../../../Part11/ObjectTypes/AuditHistoryDeleteEventType/readme.md)|

The references from the AuditHistoryAtTimeDeleteEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ReqTimes](#ReqTimes)|[UtcTime](../../../Part3/DataTypes/UtcTime/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[OldValues](#OldValues)|[DataValue](../../../Part4/DataTypes/DataValue/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


