<!-- objecttype -->
## FileTransferStateMachineType
The representation of the FileTransferStateMachineType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|FileTransferStateMachineType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[FiniteStateMachineType](../../../Part5/ObjectTypes/FiniteStateMachineType/readme.md)|

The references from the FileTransferStateMachineType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|Idle||[InitialStateType](../../Part5/ObjectTypes/InitialStateType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|ReadPrepare||[StateType](../../Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|ReadTransfer||[StateType](../../Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|ApplyWrite||[StateType](../../Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|Error||[StateType](../../Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|IdleToReadPrepare||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|ReadPrepareToReadTransfer||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|ReadTransferToIdle||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|IdleToApplyWrite||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|ApplyWriteToIdle||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|ReadPrepareToError||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|ReadTransferToError||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|ApplyWriteToError||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|ErrorToIdle||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|Reset|||[Mandatory](../../Objects/Mandatory/readme.md)|

