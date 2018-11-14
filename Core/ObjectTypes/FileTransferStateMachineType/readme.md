<!-- objecttype -->
## FileTransferStateMachineType
  
<!-- end of text -->
The representation of the FileTransferStateMachineType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15803|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|FileTransferStateMachineType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[FiniteStateMachineType](../../ObjectTypes/FiniteStateMachineType/readme.md)|
|Categories||

The references from the FileTransferStateMachineType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[Idle](#Idle)||[InitialStateType](../../ObjectTypes/InitialStateType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[ReadPrepare](#ReadPrepare)||[StateType](../../ObjectTypes/StateType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[ReadTransfer](#ReadTransfer)||[StateType](../../ObjectTypes/StateType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[ApplyWrite](#ApplyWrite)||[StateType](../../ObjectTypes/StateType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[Error](#Error)||[StateType](../../ObjectTypes/StateType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[IdleToReadPrepare](#IdleToReadPrepare)||[TransitionType](../../ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[ReadPrepareToReadTransfer](#ReadPrepareToReadTransfer)||[TransitionType](../../ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[ReadTransferToIdle](#ReadTransferToIdle)||[TransitionType](../../ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[IdleToApplyWrite](#IdleToApplyWrite)||[TransitionType](../../ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[ApplyWriteToIdle](#ApplyWriteToIdle)||[TransitionType](../../ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[ReadPrepareToError](#ReadPrepareToError)||[TransitionType](../../ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[ReadTransferToError](#ReadTransferToError)||[TransitionType](../../ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[ApplyWriteToError](#ApplyWriteToError)||[TransitionType](../../ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[ErrorToIdle](#ErrorToIdle)||[TransitionType](../../ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[Reset](#Reset)|||[Mandatory](../../Objects/Mandatory/readme.md)|

### <a name="Reset"></a>Reset
  
**Signature**
```
    Reset(    );
```

