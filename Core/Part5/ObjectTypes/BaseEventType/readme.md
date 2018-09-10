<!-- objecttype -->
## BaseEventType
The representation of the BaseEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|BaseEventType|
|NodeClass|ObjectType|
|IsAbtract|True|
|BaseType|[BaseObjectType](../../../Part5/ObjectTypes/BaseObjectType/readme.md)|

The references from the BaseEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|EventId||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|EventType||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|SourceNode||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|SourceName||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|Time||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|ReceiveTime||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|LocalTime||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|Message||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|Severity||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|AuditEventType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|SystemEventType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|BaseModelChangeEventType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|EventQueueOverflowEventType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|ProgressEventType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|TransitionEventType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|ConditionType||||

