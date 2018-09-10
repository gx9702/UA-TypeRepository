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
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[HighHighLimit](#HighHighLimit)|[Double](../../../Part3/DataTypes/Double/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[HighLimit](#HighLimit)|[Double](../../../Part3/DataTypes/Double/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[LowLimit](#LowLimit)|[Double](../../../Part3/DataTypes/Double/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[LowLowLimit](#LowLowLimit)|[Double](../../../Part3/DataTypes/Double/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[BaseHighHighLimit](#BaseHighHighLimit)|[Double](../../../Part3/DataTypes/Double/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[BaseHighLimit](#BaseHighLimit)|[Double](../../../Part3/DataTypes/Double/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[BaseLowLimit](#BaseLowLimit)|[Double](../../../Part3/DataTypes/Double/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[BaseLowLowLimit](#BaseLowLowLimit)|[Double](../../../Part3/DataTypes/Double/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[ExclusiveLimitAlarmType](#ExclusiveLimitAlarmType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[NonExclusiveLimitAlarmType](#NonExclusiveLimitAlarmType)||||


