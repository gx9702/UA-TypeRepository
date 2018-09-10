<!-- objecttype -->
## NonExclusiveLimitAlarmType
The representation of the NonExclusiveLimitAlarmType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|NonExclusiveLimitAlarmType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[LimitAlarmType](../../../Part9/ObjectTypes/LimitAlarmType/readme.md)|

The references from the NonExclusiveLimitAlarmType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|ActiveState||[TwoStateVariableType](../../Part9/VariableTypes/TwoStateVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|HighHighState||[TwoStateVariableType](../../Part9/VariableTypes/TwoStateVariableType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|HighState||[TwoStateVariableType](../../Part9/VariableTypes/TwoStateVariableType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|LowState||[TwoStateVariableType](../../Part9/VariableTypes/TwoStateVariableType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|LowLowState||[TwoStateVariableType](../../Part9/VariableTypes/TwoStateVariableType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|NonExclusiveLevelAlarmType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|NonExclusiveDeviationAlarmType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|NonExclusiveRateOfChangeAlarmType||||

