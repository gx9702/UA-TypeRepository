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
|BaseType|[LimitAlarmType](../../../Part9/ObjectTypes/LimitAlarmType/readme.md)|
|Categories|Part9|

The references from the ExclusiveLimitAlarmType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[ActiveState](#ActiveState)|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)|[TwoStateVariableType](../../Part9/VariableTypes/TwoStateVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[LimitState](#LimitState)||[ExclusiveLimitStateMachineType](../../Part9/ObjectTypes/ExclusiveLimitStateMachineType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[ExclusiveLevelAlarmType](#ExclusiveLevelAlarmType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[ExclusiveDeviationAlarmType](#ExclusiveDeviationAlarmType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[ExclusiveRateOfChangeAlarmType](#ExclusiveRateOfChangeAlarmType)||||


