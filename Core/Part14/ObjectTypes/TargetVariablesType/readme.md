<!-- objecttype -->
## TargetVariablesType
The representation of the TargetVariablesType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|TargetVariablesType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[SubscribedDataSetType](../../../Part14/ObjectTypes/SubscribedDataSetType/readme.md)|

The references from the TargetVariablesType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|TargetVariables||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|AddTargetVariables|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|RemoveTargetVariables|||[Optional](../../Objects/Optional/readme.md)|

