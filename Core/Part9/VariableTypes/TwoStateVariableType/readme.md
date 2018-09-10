<!-- objecttype -->
## TwoStateVariableType
The representation of the TwoStateVariableType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|TwoStateVariableType|
|NodeClass|VariableType|
|IsAbtract|False|
|BaseType|[StateVariableType](../../../Part5/VariableTypes/StateVariableType/readme.md)|

The references from the TwoStateVariableType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|Id||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|TransitionTime||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|EffectiveTransitionTime||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|TrueState||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|FalseState||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|

