<!-- objecttype -->
## DiscrepancyAlarmType
The representation of the DiscrepancyAlarmType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|DiscrepancyAlarmType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[AlarmConditionType](../../../Part9/ObjectTypes/AlarmConditionType/readme.md)|

The references from the DiscrepancyAlarmType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|TargetValueNode||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|ExpectedTime||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|Tolerance||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|

