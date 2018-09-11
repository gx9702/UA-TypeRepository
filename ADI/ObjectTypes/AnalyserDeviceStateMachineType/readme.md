<!-- objecttype -->
## AnalyserDeviceStateMachineType
  
<!-- end of text -->
The representation of the AnalyserDeviceStateMachineType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|ns=1;i=1002|
|NamespaceUri|http://opcfoundation.org/UA/ADI/|
|BrowseName|AnalyserDeviceStateMachineType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[FiniteStateMachineType](../../../Core/Part5/ObjectTypes/FiniteStateMachineType/readme.md)|
|Categories||

The references from the AnalyserDeviceStateMachineType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Powerup](#Powerup)||[InitialStateType](../../../Core/Part5/ObjectTypes/InitialStateType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Operating](#Operating)||[StateType](../../../Core/Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Local](#Local)||[StateType](../../../Core/Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Maintenance](#Maintenance)||[StateType](../../../Core/Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Shutdown](#Shutdown)||[StateType](../../../Core/Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[PowerupToOperatingTransition](#PowerupToOperatingTransition)||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[OperatingToLocalTransition](#OperatingToLocalTransition)||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[OperatingToMaintenanceTransition](#OperatingToMaintenanceTransition)||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[LocalToOperatingTransition](#LocalToOperatingTransition)||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[LocalToMaintenanceTransition](#LocalToMaintenanceTransition)||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[MaintenanceToOperatingTransition](#MaintenanceToOperatingTransition)||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[MaintenanceToLocalTransition](#MaintenanceToLocalTransition)||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[OperatingToShutdownTransition](#OperatingToShutdownTransition)||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[LocalToShutdownTransition](#LocalToShutdownTransition)||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[MaintenanceToShutdownTransition](#MaintenanceToShutdownTransition)||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||


