<!-- objecttype -->
## AnalyserChannelStateMachineType
Contains a nested state model that defines the top level states Operating, Local and Maintenance  
<!-- end of text -->
The representation of the AnalyserChannelStateMachineType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|ns=1;i=1007|
|NamespaceUri|http://opcfoundation.org/UA/ADI/|
|BrowseName|AnalyserChannelStateMachineType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[FiniteStateMachineType](../../../Core/Part5/ObjectTypes/FiniteStateMachineType/readme.md)|
|Categories||

The references from the AnalyserChannelStateMachineType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[OperatingSubStateMachine](#OperatingSubStateMachine)||[AnalyserChannel_OperatingModeSubStateMachineType](../../ObjectTypes/AnalyserChannel_OperatingModeSubStateMachineType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[LocalSubStateMachine](#LocalSubStateMachine)||[FiniteStateMachineType](../../../Core/Part5/ObjectTypes/FiniteStateMachineType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[MaintenanceSubStateMachine](#MaintenanceSubStateMachine)||[FiniteStateMachineType](../../../Core/Part5/ObjectTypes/FiniteStateMachineType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[SlaveMode](#SlaveMode)||[InitialStateType](../../../Core/Part5/ObjectTypes/InitialStateType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Operating](#Operating)||[AnalyserChannelOperatingStateType](../../ObjectTypes/AnalyserChannelOperatingStateType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Local](#Local)||[AnalyserChannelLocalStateType](../../ObjectTypes/AnalyserChannelLocalStateType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Maintenance](#Maintenance)||[AnalyserChannelMaintenanceStateType](../../ObjectTypes/AnalyserChannelMaintenanceStateType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[SlaveModeToOperatingTransition](#SlaveModeToOperatingTransition)||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[OperatingToLocalTransition](#OperatingToLocalTransition)||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[OperatingToMaintenanceTransition](#OperatingToMaintenanceTransition)||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[LocalToOperatingTransition](#LocalToOperatingTransition)||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[LocalToMaintenanceTransition](#LocalToMaintenanceTransition)||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[MaintenanceToOperatingTransition](#MaintenanceToOperatingTransition)||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[MaintenanceToLocalTransition](#MaintenanceToLocalTransition)||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[OperatingToSlaveModeTransition](#OperatingToSlaveModeTransition)||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[LocalToSlaveModeTransition](#LocalToSlaveModeTransition)||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[MaintenanceToSlaveModeTransition](#MaintenanceToSlaveModeTransition)||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||


