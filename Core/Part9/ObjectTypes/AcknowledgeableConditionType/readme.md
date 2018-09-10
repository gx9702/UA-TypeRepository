<!-- objecttype -->
## AcknowledgeableConditionType
The representation of the AcknowledgeableConditionType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|AcknowledgeableConditionType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[ConditionType](../../../Part9/ObjectTypes/ConditionType/readme.md)|

The references from the AcknowledgeableConditionType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|EnabledState||[TwoStateVariableType](../../Part9/VariableTypes/TwoStateVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|AckedState||[TwoStateVariableType](../../Part9/VariableTypes/TwoStateVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|ConfirmedState||[TwoStateVariableType](../../Part9/VariableTypes/TwoStateVariableType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|Acknowledge|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|Confirm|||[Optional](../../Objects/Optional/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|AlarmConditionType||||

