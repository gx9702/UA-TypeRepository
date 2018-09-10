<!-- objecttype -->
## StateVariableType
The representation of the StateVariableType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|StateVariableType|
|NodeClass|VariableType|
|IsAbtract|False|
|BaseType|[BaseDataVariableType](../../../Part5/VariableTypes/BaseDataVariableType/readme.md)|

The references from the StateVariableType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|Id||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|Name||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|Number||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|EffectiveDisplayName||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|VariableType|FiniteStateVariableType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|VariableType|TwoStateVariableType||||

