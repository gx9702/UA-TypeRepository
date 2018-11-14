<!-- objecttype -->
## AlarmMetricsType
  
<!-- end of text -->
The representation of the AlarmMetricsType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=17279|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|AlarmMetricsType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[BaseObjectType](../../ObjectTypes/BaseObjectType/readme.md)|
|Categories||

The references from the AlarmMetricsType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[AlarmCount](#AlarmCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[StartTime](#StartTime)|[UtcTime](../../DataTypes/UtcTime/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[MaximumActiveState](#MaximumActiveState)|[Duration](../../DataTypes/Duration/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[MaximumUnAck](#MaximumUnAck)|[Duration](../../DataTypes/Duration/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[CurrentAlarmRate](#CurrentAlarmRate)|[Double](../../DataTypes/Double/readme.md)|[AlarmRateVariableType](../../VariableTypes/AlarmRateVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[MaximumAlarmRate](#MaximumAlarmRate)|[Double](../../DataTypes/Double/readme.md)|[AlarmRateVariableType](../../VariableTypes/AlarmRateVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[MaximumReAlarmCount](#MaximumReAlarmCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[AverageAlarmRate](#AverageAlarmRate)|[Double](../../DataTypes/Double/readme.md)|[AlarmRateVariableType](../../VariableTypes/AlarmRateVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[Reset](#Reset)|||[Mandatory](../../Objects/Mandatory/readme.md)|

### <a name="Reset"></a>Reset
  
**Signature**
```
    Reset(    );
```

