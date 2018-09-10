<!-- objecttype -->
## FiniteStateMachineType
The representation of the FiniteStateMachineType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|FiniteStateMachineType|
|NodeClass|ObjectType|
|IsAbtract|True|
|BaseType|[StateMachineType](../../../Part5/ObjectTypes/StateMachineType/readme.md)|

The references from the FiniteStateMachineType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|CurrentState||[FiniteStateVariableType](../../Part5/VariableTypes/FiniteStateVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|LastTransition||[FiniteTransitionVariableType](../../Part5/VariableTypes/FiniteTransitionVariableType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|AvailableStates||[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|AvailableTransitions||[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|FileTransferStateMachineType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|ShelvedStateMachineType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|ExclusiveLimitStateMachineType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|ProgramStateMachineType||||

