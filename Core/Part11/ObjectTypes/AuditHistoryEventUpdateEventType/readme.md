<!-- objecttype -->
## AuditHistoryEventUpdateEventType
  
The representation of the AuditHistoryEventUpdateEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|AuditHistoryEventUpdateEventType|
|NodeClass|ObjectType|
|IsAbtract|True|
|BaseType|[AuditHistoryUpdateEventType](../../../Part5/ObjectTypes/AuditHistoryUpdateEventType/readme.md)|

The references from the AuditHistoryEventUpdateEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[UpdatedNode](#UpdatedNode)|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[PerformInsertReplace](#PerformInsertReplace)|[PerformUpdateType](../../../Part4/DataTypes/PerformUpdateType/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[Filter](#Filter)|[EventFilter](../../../Part4/DataTypes/EventFilter/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[NewValues](#NewValues)|[HistoryEventFieldList](../../../Part4/DataTypes/HistoryEventFieldList/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[OldValues](#OldValues)|[HistoryEventFieldList](../../../Part4/DataTypes/HistoryEventFieldList/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


