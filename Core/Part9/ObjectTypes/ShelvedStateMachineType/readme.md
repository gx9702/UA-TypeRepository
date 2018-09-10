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
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|UnshelveTime||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|Unshelved||[StateType](../../Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|TimedShelved||[StateType](../../Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|OneShotShelved||[StateType](../../Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|UnshelvedToTimedShelved||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|UnshelvedToOneShotShelved||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|TimedShelvedToUnshelved||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|TimedShelvedToOneShotShelved||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|OneShotShelvedToUnshelved||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|OneShotShelvedToTimedShelved||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|TimedShelve|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|Unshelve|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|OneShotShelve|||[Mandatory](../../Objects/Mandatory/readme.md)|

