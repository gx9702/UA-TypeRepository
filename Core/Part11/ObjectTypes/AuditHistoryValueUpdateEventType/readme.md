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
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[UpdatedNode](#UpdatedNode)|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[PerformInsertReplace](#PerformInsertReplace)|[PerformUpdateType](../../../Part4/DataTypes/PerformUpdateType/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[NewValues](#NewValues)|[DataValue](../../../Part4/DataTypes/DataValue/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[OldValues](#OldValues)|[DataValue](../../../Part4/DataTypes/DataValue/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


