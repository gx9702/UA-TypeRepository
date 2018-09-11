<!-- objecttype -->
## TopologyElementType
Defines the basic information components for all configurable elements in a device topology  
<!-- end of text -->
The representation of the TopologyElementType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|ns=1;i=1001|
|NamespaceUri|http://opcfoundation.org/UA/DI/|
|BrowseName|TopologyElementType|
|NodeClass|ObjectType|
|IsAbstract|True|
|BaseType|[BaseObjectType](../../../Core/Part5/ObjectTypes/BaseObjectType/readme.md)|
|Categories||

The references from the TopologyElementType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[ParameterSet](#ParameterSet)||[BaseObjectType](../../../Core/Part5/ObjectTypes/BaseObjectType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[MethodSet](#MethodSet)||[BaseObjectType](../../../Core/Part5/ObjectTypes/BaseObjectType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[&lt;GroupIdentifier&gt;](#&lt;GroupIdentifier&gt;)||[FunctionalGroupType](../../ObjectTypes/FunctionalGroupType/readme.md)|[OptionalPlaceholder](../../../Core/Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Identification](#Identification)||[FunctionalGroupType](../../ObjectTypes/FunctionalGroupType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Lock](#Lock)||[LockingServicesType](../../ObjectTypes/LockingServicesType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasSubtype](../../../Core/Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[DeviceType](#DeviceType)||||
|[HasSubtype](../../../Core/Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[BlockType](#BlockType)||||
|[HasSubtype](../../../Core/Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[ConnectionPointType](#ConnectionPointType)||||


