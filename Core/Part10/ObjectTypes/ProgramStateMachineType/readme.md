<!-- objecttype -->
## ProgramStateMachineType
The representation of the ProgramStateMachineType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|ProgramStateMachineType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[FiniteStateMachineType](../../../Part5/ObjectTypes/FiniteStateMachineType/readme.md)|

The references from the ProgramStateMachineType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|CurrentState||[FiniteStateVariableType](../../Part5/VariableTypes/FiniteStateVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|LastTransition||[FiniteTransitionVariableType](../../Part5/VariableTypes/FiniteTransitionVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|Creatable||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)||
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|Deletable||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|AutoDelete||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|RecycleCount||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|InstanceCount||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)||
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|MaxInstanceCount||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)||
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|MaxRecycleCount||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|ProgramDiagnostics||[ProgramDiagnostic2Type](../../Part10/VariableTypes/ProgramDiagnostic2Type/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|FinalResultData||[BaseObjectType](../../Part5/ObjectTypes/BaseObjectType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|Halted||[StateType](../../Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|Ready||[StateType](../../Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|Running||[StateType](../../Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|Suspended||[StateType](../../Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|HaltedToReady||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|ReadyToRunning||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|RunningToHalted||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|RunningToReady||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|RunningToSuspended||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|SuspendedToRunning||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|SuspendedToHalted||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|SuspendedToReady||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|ReadyToHalted||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|Start|||[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|Suspend|||[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|Resume|||[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|Halt|||[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|Reset|||[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|

