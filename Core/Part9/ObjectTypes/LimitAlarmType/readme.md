<!-- objecttype -->
## LimitAlarmType
The representation of the LimitAlarmType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|LimitAlarmType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[AlarmConditionType](../../../Part9/ObjectTypes/AlarmConditionType/readme.md)|

The references from the LimitAlarmType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|HighHighLimit||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|HighLimit||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|LowLimit||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|LowLowLimit||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|BaseHighHighLimit||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|BaseHighLimit||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|BaseLowLimit||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|BaseLowLowLimit||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|ExclusiveLimitAlarmType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|NonExclusiveLimitAlarmType||||

