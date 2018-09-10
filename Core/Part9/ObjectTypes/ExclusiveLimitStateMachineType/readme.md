<!-- objecttype -->
## ExclusiveLimitStateMachineType
  
The representation of the ExclusiveLimitStateMachineType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|ExclusiveLimitStateMachineType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[FiniteStateMachineType](../../../Part5/ObjectTypes/FiniteStateMachineType/readme.md)|

The references from the ExclusiveLimitStateMachineType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[HighHigh](#HighHigh)||[StateType](../../Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[High](#High)||[StateType](../../Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Low](#Low)||[StateType](../../Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[LowLow](#LowLow)||[StateType](../../Part5/ObjectTypes/StateType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[LowLowToLow](#LowLowToLow)||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[LowToLowLow](#LowToLowLow)||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[HighHighToHigh](#HighHighToHigh)||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[HighToHighHigh](#HighToHighHigh)||[TransitionType](../../Part5/ObjectTypes/TransitionType/readme.md)||


