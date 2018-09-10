<!-- objecttype -->
## AlarmMetricsType
The representation of the AlarmMetricsType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|AlarmMetricsType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[BaseObjectType](../../../Part5/ObjectTypes/BaseObjectType/readme.md)|

The references from the AlarmMetricsType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|AlarmCount||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|StartTime||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|MaximumActiveState||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|MaximumUnAck||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|CurrentAlarmRate||[AlarmRateVariableType](../../Part9/VariableTypes/AlarmRateVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|MaximumAlarmRate||[AlarmRateVariableType](../../Part9/VariableTypes/AlarmRateVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|MaximumReAlarmCount||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|AverageAlarmRate||[AlarmRateVariableType](../../Part9/VariableTypes/AlarmRateVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|Reset|||[Mandatory](../../Objects/Mandatory/readme.md)|

