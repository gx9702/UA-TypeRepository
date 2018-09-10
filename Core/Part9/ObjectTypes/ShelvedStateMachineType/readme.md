<!-- objecttype -->
## ShelvedStateMachineType

The representation of the ShelvedStateMachineType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|ShelvedStateMachineType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[FiniteStateMachineType](../../../Part5/ObjectTypes/FiniteStateMachineType/readme.md)|

The references from the ShelvedStateMachineType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[UnshelveTime](#UnshelveTime)|[Duration](../../../Part3/DataTypes/Duration/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Unshelved](#Unshelved)||[StateType](../../Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[TimedShelved](#TimedShelved)||[StateType](../../Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[OneShotShelved](#OneShotShelved)||[StateType](../../Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[UnshelvedToTimedShelved](#UnshelvedToTimedShelved)||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[UnshelvedToOneShotShelved](#UnshelvedToOneShotShelved)||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[TimedShelvedToUnshelved](#TimedShelvedToUnshelved)||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[TimedShelvedToOneShotShelved](#TimedShelvedToOneShotShelved)||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[OneShotShelvedToUnshelved](#OneShotShelvedToUnshelved)||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[OneShotShelvedToTimedShelved](#OneShotShelvedToTimedShelved)||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[TimedShelve](#TimedShelve)|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[Unshelve](#Unshelve)|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[OneShotShelve](#OneShotShelve)|||[Mandatory](../../Objects/Mandatory/readme.md)|

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

