<!-- objecttype -->
## TransitionEventType
  
<!-- end of text -->
The representation of the TransitionEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2311|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|TransitionEventType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[BaseEventType](../../ObjectTypes/BaseEventType/readme.md)|
|Categories||

The references from the TransitionEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[Transition](#Transition)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|[TransitionVariableType](../../VariableTypes/TransitionVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[FromState](#FromState)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|[StateVariableType](../../VariableTypes/StateVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[ToState](#ToState)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|[StateVariableType](../../VariableTypes/StateVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[ProgramTransitionEventType](#ProgramTransitionEventType)||||


