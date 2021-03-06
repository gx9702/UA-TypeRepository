<!-- objecttype -->
## ExclusiveLimitAlarmType
  
<!-- end of text -->
The representation of the ExclusiveLimitAlarmType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=9341|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|ExclusiveLimitAlarmType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[LimitAlarmType](../../ObjectTypes/LimitAlarmType/readme.md)|
|Categories||

The references from the ExclusiveLimitAlarmType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[ActiveState](#ActiveState)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|[TwoStateVariableType](../../VariableTypes/TwoStateVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[LimitState](#LimitState)||[ExclusiveLimitStateMachineType](../../ObjectTypes/ExclusiveLimitStateMachineType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[ExclusiveLevelAlarmType](#ExclusiveLevelAlarmType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[ExclusiveDeviationAlarmType](#ExclusiveDeviationAlarmType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[ExclusiveRateOfChangeAlarmType](#ExclusiveRateOfChangeAlarmType)||||


