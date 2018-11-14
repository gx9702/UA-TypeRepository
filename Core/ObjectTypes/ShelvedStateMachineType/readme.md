<!-- objecttype -->
## ShelvedStateMachineType
  
<!-- end of text -->
The representation of the ShelvedStateMachineType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2929|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|ShelvedStateMachineType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[FiniteStateMachineType](../../ObjectTypes/FiniteStateMachineType/readme.md)|
|Categories||

The references from the ShelvedStateMachineType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[UnshelveTime](#UnshelveTime)|[Duration](../../DataTypes/Duration/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[Unshelved](#Unshelved)||[StateType](../../ObjectTypes/StateType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[TimedShelved](#TimedShelved)||[StateType](../../ObjectTypes/StateType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[OneShotShelved](#OneShotShelved)||[StateType](../../ObjectTypes/StateType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[UnshelvedToTimedShelved](#UnshelvedToTimedShelved)||[TransitionType](../../ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[UnshelvedToOneShotShelved](#UnshelvedToOneShotShelved)||[TransitionType](../../ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[TimedShelvedToUnshelved](#TimedShelvedToUnshelved)||[TransitionType](../../ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[TimedShelvedToOneShotShelved](#TimedShelvedToOneShotShelved)||[TransitionType](../../ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[OneShotShelvedToUnshelved](#OneShotShelvedToUnshelved)||[TransitionType](../../ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[OneShotShelvedToTimedShelved](#OneShotShelvedToTimedShelved)||[TransitionType](../../ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[TimedShelve](#TimedShelve)|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[Unshelve](#Unshelve)|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[OneShotShelve](#OneShotShelve)|||[Mandatory](../../Objects/Mandatory/readme.md)|

### <a name="TimedShelve"></a>TimedShelve
  
**Signature**
```
    TimedShelve(
        [in]  Duration ShelvingTime
    );
```

|Argument|Description|
|---|---|
|ShelvingTime|If not 0, this parameter specifies a fixed time for which the Alarm is to be shelved.|

### <a name="Unshelve"></a>Unshelve
  
**Signature**
```
    Unshelve(    );
```
### <a name="OneShotShelve"></a>OneShotShelve
  
**Signature**
```
    OneShotShelve(    );
```

