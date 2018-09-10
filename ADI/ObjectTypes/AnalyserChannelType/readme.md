<!-- objecttype -->
## AnalyserChannelType
The representation of the AnalyserChannelType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|AnalyserChannelType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[TopologyElementType](../../../DI/ObjectTypes/TopologyElementType/readme.md)|

The references from the AnalyserChannelType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|ParameterSet||[BaseObjectType](../../../Core/Part5/ObjectTypes/BaseObjectType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|MethodSet||[BaseObjectType](../../../Core/Part5/ObjectTypes/BaseObjectType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|&lt;GroupIdentifier&gt;||[FunctionalGroupType](../../../DI/ObjectTypes/FunctionalGroupType/readme.md)|[OptionalPlaceholder](../../../Core/Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|Configuration||[FunctionalGroupType](../../../DI/ObjectTypes/FunctionalGroupType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|Status||[FunctionalGroupType](../../../DI/ObjectTypes/FunctionalGroupType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|ChannelStateMachine||[AnalyserChannelStateMachineType](../../ObjectTypes/AnalyserChannelStateMachineType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|&lt;StreamIdentifier&gt;||[StreamType](../../ObjectTypes/StreamType/readme.md)|[OptionalPlaceholder](../../../Core/Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|&lt;AccessorySlotIdentifier&gt;||[AccessorySlotType](../../ObjectTypes/AccessorySlotType/readme.md)|[OptionalPlaceholder](../../../Core/Objects/OptionalPlaceholder/readme.md)|

