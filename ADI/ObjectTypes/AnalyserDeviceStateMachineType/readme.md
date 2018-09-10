<!-- objecttype -->
## AnalyserDeviceStateMachineType
The representation of the AnalyserDeviceStateMachineType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|AnalyserDeviceStateMachineType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[FiniteStateMachineType](../../../Core/Part5/ObjectTypes/FiniteStateMachineType/readme.md)|

The references from the AnalyserDeviceStateMachineType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|Powerup||[InitialStateType](../../../Core/Part5/ObjectTypes/InitialStateType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|Operating||[StateType](../../../Core/Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|Local||[StateType](../../../Core/Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|Maintenance||[StateType](../../../Core/Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|Shutdown||[StateType](../../../Core/Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|PowerupToOperatingTransition||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|OperatingToLocalTransition||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|OperatingToMaintenanceTransition||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|LocalToOperatingTransition||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|LocalToMaintenanceTransition||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|MaintenanceToOperatingTransition||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|MaintenanceToLocalTransition||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|OperatingToShutdownTransition||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|LocalToShutdownTransition||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|MaintenanceToShutdownTransition||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||

