<!-- objecttype -->
## ProgramStateMachineType
A state machine for a program.
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
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[CurrentState](#CurrentState)|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)|[FiniteStateVariableType](../../Part5/VariableTypes/FiniteStateVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[LastTransition](#LastTransition)|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)|[FiniteTransitionVariableType](../../Part5/VariableTypes/FiniteTransitionVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[Creatable](#Creatable)|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)||
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[Deletable](#Deletable)|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[AutoDelete](#AutoDelete)|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[RecycleCount](#RecycleCount)|[Int32](../../../Part3/DataTypes/Int32/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[InstanceCount](#InstanceCount)|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)||
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[MaxInstanceCount](#MaxInstanceCount)|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)||
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[MaxRecycleCount](#MaxRecycleCount)|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[ProgramDiagnostics](#ProgramDiagnostics)|[ProgramDiagnostic2DataType](../../../Part10/DataTypes/ProgramDiagnostic2DataType/readme.md)|[ProgramDiagnostic2Type](../../Part10/VariableTypes/ProgramDiagnostic2Type/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[FinalResultData](#FinalResultData)||[BaseObjectType](../../Part5/ObjectTypes/BaseObjectType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Halted](#Halted)||[StateType](../../Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Ready](#Ready)||[StateType](../../Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Running](#Running)||[StateType](../../Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Suspended](#Suspended)||[StateType](../../Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[HaltedToReady](#HaltedToReady)||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[ReadyToRunning](#ReadyToRunning)||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[RunningToHalted](#RunningToHalted)||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[RunningToReady](#RunningToReady)||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[RunningToSuspended](#RunningToSuspended)||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[SuspendedToRunning](#SuspendedToRunning)||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[SuspendedToHalted](#SuspendedToHalted)||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[SuspendedToReady](#SuspendedToReady)||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[ReadyToHalted](#ReadyToHalted)||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[Start](#Start)|||[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[Suspend](#Suspend)|||[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[Resume](#Resume)|||[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[Halt](#Halt)|||[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[Reset](#Reset)|||[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|

### <a name="Start"></a>Start

**Signature**
```
    Start(    );
```
### <a name="Suspend"></a>Suspend

**Signature**
```
    Suspend(    );
```
### <a name="Resume"></a>Resume

**Signature**
```
    Resume(    );
```
### <a name="Halt"></a>Halt

**Signature**
```
    Halt(    );
```
### <a name="Reset"></a>Reset

**Signature**
```
    Reset(    );
```

