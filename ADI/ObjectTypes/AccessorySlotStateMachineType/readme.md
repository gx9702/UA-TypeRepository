<!-- objecttype -->
## AccessorySlotStateMachineType
Describes the behaviour of an AccessorySlot when a physical accessory is inserted or removed.
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
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Powerup](#Powerup)||[InitialStateType](../../../Core/Part5/ObjectTypes/InitialStateType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Empty](#Empty)||[StateType](../../../Core/Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Inserting](#Inserting)||[StateType](../../../Core/Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Installed](#Installed)||[StateType](../../../Core/Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Removing](#Removing)||[StateType](../../../Core/Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Shutdown](#Shutdown)||[StateType](../../../Core/Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[PowerupToEmptyTransition](#PowerupToEmptyTransition)||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[EmptyToInsertingTransition](#EmptyToInsertingTransition)||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[InsertingTransition](#InsertingTransition)||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[InsertingToRemovingTransition](#InsertingToRemovingTransition)||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[InsertingToInstalledTransition](#InsertingToInstalledTransition)||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[InstalledToRemovingTransition](#InstalledToRemovingTransition)||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[RemovingTransition](#RemovingTransition)||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[RemovingToEmptyTransition](#RemovingToEmptyTransition)||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[EmptyToShutdownTransition](#EmptyToShutdownTransition)||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[InsertingToShutdownTransition](#InsertingToShutdownTransition)||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[InstalledToShutdownTransition](#InstalledToShutdownTransition)||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[RemovingToShutdownTransition](#RemovingToShutdownTransition)||[TransitionType](../../../Core/Part5/ObjectTypes/TransitionType/readme.md)||


