<!-- objecttype -->
## AnalyserChannelStateMachineType
The representation of the AnalyserChannelStateMachineType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|AnalyserChannelStateMachineType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[FiniteStateMachineType](../../../Core/Part5/ObjectTypes/FiniteStateMachineType/readme.md)|

The references from the AnalyserChannelStateMachineType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|OperatingSubStateMachine||[AnalyserChannel_OperatingModeSubStateMachineType](../../ObjectTypes/AnalyserChannel_OperatingModeSubStateMachineType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|LocalSubStateMachine||[FiniteStateMachineType](../../../Core/Part5/ObjectTypes/FiniteStateMachineType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|MaintenanceSubStateMachine||[FiniteStateMachineType](../../../Core/Part5/ObjectTypes/FiniteStateMachineType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|SlaveMode||[InitialStateType](../../../Core/Part5/ObjectTypes/InitialStateType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|Operating||[AnalyserChannelOperatingStateType](../../ObjectTypes/AnalyserChannelOperatingStateType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|Local||[AnalyserChannelLocalStateType](../../ObjectTypes/AnalyserChannelLocalStateType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|Maintenance||[AnalyserChannelMaintenanceStateType](../../ObjectTypes/AnalyserChannelMaintenanceStateType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|SlaveModeToOperatingTransition||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|OperatingToLocalTransition||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|OperatingToMaintenanceTransition||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|LocalToOperatingTransition||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|LocalToMaintenanceTransition||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|MaintenanceToOperatingTransition||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|MaintenanceToLocalTransition||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|OperatingToSlaveModeTransition||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|LocalToSlaveModeTransition||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|MaintenanceToSlaveModeTransition||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||

