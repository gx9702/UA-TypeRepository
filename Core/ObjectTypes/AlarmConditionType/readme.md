<!-- objecttype -->
## AlarmConditionType
  
<!-- end of text -->
The representation of the AlarmConditionType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2915|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|AlarmConditionType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[AcknowledgeableConditionType](../../ObjectTypes/AcknowledgeableConditionType/readme.md)|
|Categories||

The references from the AlarmConditionType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[EnabledState](#EnabledState)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|[TwoStateVariableType](../../VariableTypes/TwoStateVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[ActiveState](#ActiveState)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|[TwoStateVariableType](../../VariableTypes/TwoStateVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[InputNode](#InputNode)|[NodeId](../../DataTypes/NodeId/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[SuppressedState](#SuppressedState)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|[TwoStateVariableType](../../VariableTypes/TwoStateVariableType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[OutOfServiceState](#OutOfServiceState)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|[TwoStateVariableType](../../VariableTypes/TwoStateVariableType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[ShelvingState](#ShelvingState)||[ShelvedStateMachineType](../../ObjectTypes/ShelvedStateMachineType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[SuppressedOrShelved](#SuppressedOrShelved)|[Boolean](../../DataTypes/Boolean/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[MaxTimeShelved](#MaxTimeShelved)|[Duration](../../DataTypes/Duration/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[AudibleEnabled](#AudibleEnabled)|[Boolean](../../DataTypes/Boolean/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[AudibleSound](#AudibleSound)|[AudioDataType](../../DataTypes/AudioDataType/readme.md)|[AudioVariableType](../../VariableTypes/AudioVariableType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[SilenceState](#SilenceState)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|[TwoStateVariableType](../../VariableTypes/TwoStateVariableType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[OnDelay](#OnDelay)|[Duration](../../DataTypes/Duration/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[OffDelay](#OffDelay)|[Duration](../../DataTypes/Duration/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[FirstInGroupFlag](#FirstInGroupFlag)|[Boolean](../../DataTypes/Boolean/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[FirstInGroup](#FirstInGroup)||[AlarmGroupType](../../ObjectTypes/AlarmGroupType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[LatchedState](#LatchedState)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|[TwoStateVariableType](../../VariableTypes/TwoStateVariableType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasAlarmSuppressionGroup](../../ReferenceTypes/HasAlarmSuppressionGroup/readme.md)|Object|[&lt;AlarmGroup&gt;](#&lt;AlarmGroup&gt;)||[AlarmGroupType](../../ObjectTypes/AlarmGroupType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ReAlarmTime](#ReAlarmTime)|[Duration](../../DataTypes/Duration/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ReAlarmRepeatCount](#ReAlarmRepeatCount)|[Int16](../../DataTypes/Int16/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[Silence](#Silence)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[Suppress](#Suppress)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[Unsuppress](#Unsuppress)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[RemoveFromService](#RemoveFromService)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[PlaceInService](#PlaceInService)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[Reset](#Reset)|||[Optional](../../Objects/Optional/readme.md)|
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[LimitAlarmType](#LimitAlarmType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[DiscreteAlarmType](#DiscreteAlarmType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[DiscrepancyAlarmType](#DiscrepancyAlarmType)||||

### <a name="Silence"></a>Silence
  
**Signature**
```
    Silence(    );
```
### <a name="Suppress"></a>Suppress
  
**Signature**
```
    Suppress(    );
```
### <a name="Unsuppress"></a>Unsuppress
  
**Signature**
```
    Unsuppress(    );
```
### <a name="RemoveFromService"></a>RemoveFromService
  
**Signature**
```
    RemoveFromService(    );
```
### <a name="PlaceInService"></a>PlaceInService
  
**Signature**
```
    PlaceInService(    );
```
### <a name="Reset"></a>Reset
  
**Signature**
```
    Reset(    );
```

