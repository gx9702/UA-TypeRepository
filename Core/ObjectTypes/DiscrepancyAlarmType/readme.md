<!-- objecttype -->
## DiscrepancyAlarmType
  
<!-- end of text -->
The representation of the DiscrepancyAlarmType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=17080|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|DiscrepancyAlarmType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[AlarmConditionType](../../ObjectTypes/AlarmConditionType/readme.md)|
|Categories||

The references from the DiscrepancyAlarmType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[TargetValueNode](#TargetValueNode)|[NodeId](../../DataTypes/NodeId/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ExpectedTime](#ExpectedTime)|[Duration](../../DataTypes/Duration/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[Tolerance](#Tolerance)|[Double](../../DataTypes/Double/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|


