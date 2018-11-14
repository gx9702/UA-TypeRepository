<!-- objecttype -->
## ProgramStateMachineType
A state machine for a program.  
<!-- end of text -->
The representation of the ProgramStateMachineType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2391|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|ProgramStateMachineType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[FiniteStateMachineType](../../ObjectTypes/FiniteStateMachineType/readme.md)|
|Categories||

The references from the ProgramStateMachineType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[CurrentState](#CurrentState)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|[FiniteStateVariableType](../../VariableTypes/FiniteStateVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[LastTransition](#LastTransition)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|[FiniteTransitionVariableType](../../VariableTypes/FiniteTransitionVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[Creatable](#Creatable)|[Boolean](../../DataTypes/Boolean/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)||
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[Deletable](#Deletable)|[Boolean](../../DataTypes/Boolean/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[AutoDelete](#AutoDelete)|[Boolean](../../DataTypes/Boolean/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[RecycleCount](#RecycleCount)|[Int32](../../DataTypes/Int32/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[InstanceCount](#InstanceCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)||
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[MaxInstanceCount](#MaxInstanceCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)||
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[MaxRecycleCount](#MaxRecycleCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[ProgramDiagnostics](#ProgramDiagnostics)|[ProgramDiagnostic2DataType](../../DataTypes/ProgramDiagnostic2DataType/readme.md)|[ProgramDiagnostic2Type](../../VariableTypes/ProgramDiagnostic2Type/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[FinalResultData](#FinalResultData)||[BaseObjectType](../../ObjectTypes/BaseObjectType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[Halted](#Halted)||[StateType](../../ObjectTypes/StateType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[Ready](#Ready)||[StateType](../../ObjectTypes/StateType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[Running](#Running)||[StateType](../../ObjectTypes/StateType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[Suspended](#Suspended)||[StateType](../../ObjectTypes/StateType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[HaltedToReady](#HaltedToReady)||[TransitionType](../../ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[ReadyToRunning](#ReadyToRunning)||[TransitionType](../../ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[RunningToHalted](#RunningToHalted)||[TransitionType](../../ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[RunningToReady](#RunningToReady)||[TransitionType](../../ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[RunningToSuspended](#RunningToSuspended)||[TransitionType](../../ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[SuspendedToRunning](#SuspendedToRunning)||[TransitionType](../../ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[SuspendedToHalted](#SuspendedToHalted)||[TransitionType](../../ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[SuspendedToReady](#SuspendedToReady)||[TransitionType](../../ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[ReadyToHalted](#ReadyToHalted)||[TransitionType](../../ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[Start](#Start)|||[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[Suspend](#Suspend)|||[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[Resume](#Resume)|||[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[Halt](#Halt)|||[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[Reset](#Reset)|||[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|

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

