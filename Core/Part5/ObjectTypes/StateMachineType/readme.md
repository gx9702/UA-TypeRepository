<!-- objecttype -->
## StateMachineType
The representation of the StateMachineType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|StateMachineType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[BaseObjectType](../../../Part5/ObjectTypes/BaseObjectType/readme.md)|

The references from the StateMachineType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|CurrentState|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)|[StateVariableType](../../Part5/VariableTypes/StateVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|LastTransition|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)|[TransitionVariableType](../../Part5/VariableTypes/TransitionVariableType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|FiniteStateMachineType||||

