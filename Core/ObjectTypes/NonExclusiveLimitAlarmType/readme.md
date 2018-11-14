<!-- objecttype -->
## NonExclusiveLimitAlarmType
  
<!-- end of text -->
The representation of the NonExclusiveLimitAlarmType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=9906|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|NonExclusiveLimitAlarmType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[LimitAlarmType](../../ObjectTypes/LimitAlarmType/readme.md)|
|Categories||

The references from the NonExclusiveLimitAlarmType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[ActiveState](#ActiveState)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|[TwoStateVariableType](../../VariableTypes/TwoStateVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[HighHighState](#HighHighState)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|[TwoStateVariableType](../../VariableTypes/TwoStateVariableType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[HighState](#HighState)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|[TwoStateVariableType](../../VariableTypes/TwoStateVariableType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[LowState](#LowState)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|[TwoStateVariableType](../../VariableTypes/TwoStateVariableType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[LowLowState](#LowLowState)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|[TwoStateVariableType](../../VariableTypes/TwoStateVariableType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[NonExclusiveLevelAlarmType](#NonExclusiveLevelAlarmType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[NonExclusiveDeviationAlarmType](#NonExclusiveDeviationAlarmType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[NonExclusiveRateOfChangeAlarmType](#NonExclusiveRateOfChangeAlarmType)||||


