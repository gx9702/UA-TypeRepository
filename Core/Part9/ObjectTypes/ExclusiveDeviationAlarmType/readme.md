<!-- objecttype -->
## ExclusiveDeviationAlarmType
  
The representation of the ExclusiveDeviationAlarmType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|ExclusiveDeviationAlarmType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[ExclusiveLimitAlarmType](../../../Part9/ObjectTypes/ExclusiveLimitAlarmType/readme.md)|

The references from the ExclusiveDeviationAlarmType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[SetpointNode](#SetpointNode)|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[BaseSetpointNode](#BaseSetpointNode)|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|


