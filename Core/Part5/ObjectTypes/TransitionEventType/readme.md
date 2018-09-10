<!-- objecttype -->
## TransitionEventType
The representation of the TransitionEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|TransitionEventType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[BaseEventType](../../../Part5/ObjectTypes/BaseEventType/readme.md)|

The references from the TransitionEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|Transition|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)|[TransitionVariableType](../../Part5/VariableTypes/TransitionVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|FromState|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)|[StateVariableType](../../Part5/VariableTypes/StateVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|ToState|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)|[StateVariableType](../../Part5/VariableTypes/StateVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|ProgramTransitionEventType||||

