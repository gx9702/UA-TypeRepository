<!-- objecttype -->
## AccessorySlotStateMachineType
The representation of the AccessorySlotStateMachineType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|AccessorySlotStateMachineType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[FiniteStateMachineType](../../../Core/Part5/ObjectTypes/FiniteStateMachineType/readme.md)|

The references from the AccessorySlotStateMachineType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|Powerup||[InitialStateType](../../../Core/Part5/ObjectTypes/InitialStateType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|Empty||[StateType](../../../Core/Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|Inserting||[StateType](../../../Core/Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|Installed||[StateType](../../../Core/Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|Removing||[StateType](../../../Core/Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|Shutdown||[StateType](../../../Core/Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|PowerupToEmptyTransition||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|EmptyToInsertingTransition||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|InsertingTransition||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|InsertingToRemovingTransition||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|InsertingToInstalledTransition||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|InstalledToRemovingTransition||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|RemovingTransition||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|RemovingToEmptyTransition||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|EmptyToShutdownTransition||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|InsertingToShutdownTransition||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|InstalledToShutdownTransition||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|RemovingToShutdownTransition||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||

