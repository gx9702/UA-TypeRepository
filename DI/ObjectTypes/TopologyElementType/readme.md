<!-- objecttype -->
## TopologyElementType
The representation of the TopologyElementType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|TopologyElementType|
|NodeClass|ObjectType|
|IsAbtract|True|
|BaseType|[BaseObjectType](../../../Core/Part5/ObjectTypes/BaseObjectType/readme.md)|

The references from the TopologyElementType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|ParameterSet||[BaseObjectType](../../../Core/Part5/ObjectTypes/BaseObjectType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|MethodSet||[BaseObjectType](../../../Core/Part5/ObjectTypes/BaseObjectType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|&lt;GroupIdentifier&gt;||[FunctionalGroupType](../../ObjectTypes/FunctionalGroupType/readme.md)|[OptionalPlaceholder](../../../Core/Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|Identification||[FunctionalGroupType](../../ObjectTypes/FunctionalGroupType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|Lock||[LockingServicesType](../../ObjectTypes/LockingServicesType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasSubtype](../../../Core/Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|DeviceType||||
|[HasSubtype](../../../Core/Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|BlockType||||
|[HasSubtype](../../../Core/Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|ConnectionPointType||||

