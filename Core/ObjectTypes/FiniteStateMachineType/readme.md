<!-- objecttype -->
## FiniteStateMachineType
  
<!-- end of text -->
The representation of the FiniteStateMachineType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2771|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|FiniteStateMachineType|
|NodeClass|ObjectType|
|IsAbstract|True|
|BaseType|[StateMachineType](../../ObjectTypes/StateMachineType/readme.md)|
|Categories||

The references from the FiniteStateMachineType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[CurrentState](#CurrentState)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|[FiniteStateVariableType](../../VariableTypes/FiniteStateVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[LastTransition](#LastTransition)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|[FiniteTransitionVariableType](../../VariableTypes/FiniteTransitionVariableType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[AvailableStates](#AvailableStates)|[NodeId](../../DataTypes/NodeId/readme.md)[]|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[AvailableTransitions](#AvailableTransitions)|[NodeId](../../DataTypes/NodeId/readme.md)[]|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[FileTransferStateMachineType](#FileTransferStateMachineType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[ShelvedStateMachineType](#ShelvedStateMachineType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[ExclusiveLimitStateMachineType](#ExclusiveLimitStateMachineType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[ProgramStateMachineType](#ProgramStateMachineType)||||


