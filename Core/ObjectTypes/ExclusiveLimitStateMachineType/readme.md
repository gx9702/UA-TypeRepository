<!-- objecttype -->
## ExclusiveLimitStateMachineType
  
<!-- end of text -->
The representation of the ExclusiveLimitStateMachineType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=9318|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|ExclusiveLimitStateMachineType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[FiniteStateMachineType](../../ObjectTypes/FiniteStateMachineType/readme.md)|
|Categories||

The references from the ExclusiveLimitStateMachineType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[HighHigh](#HighHigh)||[StateType](../../ObjectTypes/StateType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[High](#High)||[StateType](../../ObjectTypes/StateType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[Low](#Low)||[StateType](../../ObjectTypes/StateType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[LowLow](#LowLow)||[StateType](../../ObjectTypes/StateType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[LowLowToLow](#LowLowToLow)||[TransitionType](../../ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[LowToLowLow](#LowToLowLow)||[TransitionType](../../ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[HighHighToHigh](#HighHighToHigh)||[TransitionType](../../ObjectTypes/TransitionType/readme.md)||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[HighToHighHigh](#HighToHighHigh)||[TransitionType](../../ObjectTypes/TransitionType/readme.md)||


