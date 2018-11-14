<!-- objecttype -->
## StateMachineType
  
<!-- end of text -->
The representation of the StateMachineType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2299|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|StateMachineType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[BaseObjectType](../../ObjectTypes/BaseObjectType/readme.md)|
|Categories||

The references from the StateMachineType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[CurrentState](#CurrentState)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|[StateVariableType](../../VariableTypes/StateVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[LastTransition](#LastTransition)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|[TransitionVariableType](../../VariableTypes/TransitionVariableType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[FiniteStateMachineType](#FiniteStateMachineType)||||


