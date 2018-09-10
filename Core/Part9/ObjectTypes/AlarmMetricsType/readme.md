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
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[AlarmCount](#AlarmCount)|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[StartTime](#StartTime)|[UtcTime](../../../Part3/DataTypes/UtcTime/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[MaximumActiveState](#MaximumActiveState)|[Duration](../../../Part3/DataTypes/Duration/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[MaximumUnAck](#MaximumUnAck)|[Duration](../../../Part3/DataTypes/Duration/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[CurrentAlarmRate](#CurrentAlarmRate)|[Double](../../../Part3/DataTypes/Double/readme.md)|[AlarmRateVariableType](../../Part9/VariableTypes/AlarmRateVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[MaximumAlarmRate](#MaximumAlarmRate)|[Double](../../../Part3/DataTypes/Double/readme.md)|[AlarmRateVariableType](../../Part9/VariableTypes/AlarmRateVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[MaximumReAlarmCount](#MaximumReAlarmCount)|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[AverageAlarmRate](#AverageAlarmRate)|[Double](../../../Part3/DataTypes/Double/readme.md)|[AlarmRateVariableType](../../Part9/VariableTypes/AlarmRateVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[Reset](#Reset)|||[Mandatory](../../Objects/Mandatory/readme.md)|

### <a name="Reset"></a>Reset

**Signature**
```
    Reset(    );
```

