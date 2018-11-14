<!-- objecttype -->
## LimitAlarmType
  
<!-- end of text -->
The representation of the LimitAlarmType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2955|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|LimitAlarmType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[AlarmConditionType](../../ObjectTypes/AlarmConditionType/readme.md)|
|Categories||

The references from the LimitAlarmType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[HighHighLimit](#HighHighLimit)|[Double](../../DataTypes/Double/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[HighLimit](#HighLimit)|[Double](../../DataTypes/Double/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[LowLimit](#LowLimit)|[Double](../../DataTypes/Double/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[LowLowLimit](#LowLowLimit)|[Double](../../DataTypes/Double/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[BaseHighHighLimit](#BaseHighHighLimit)|[Double](../../DataTypes/Double/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[BaseHighLimit](#BaseHighLimit)|[Double](../../DataTypes/Double/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[BaseLowLimit](#BaseLowLimit)|[Double](../../DataTypes/Double/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[BaseLowLowLimit](#BaseLowLowLimit)|[Double](../../DataTypes/Double/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[ExclusiveLimitAlarmType](#ExclusiveLimitAlarmType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[NonExclusiveLimitAlarmType](#NonExclusiveLimitAlarmType)||||


