<!-- objecttype -->
## NetworkType
Represents the communication means for Devices that are connected to it.  
The representation of the NetworkType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|NetworkType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[BaseObjectType](../../../Core/Part5/ObjectTypes/BaseObjectType/readme.md)|

The references from the NetworkType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[&lt;ProfileIdentifier&gt;](#&lt;ProfileIdentifier&gt;)||[ProtocolType](../../ObjectTypes/ProtocolType/readme.md)|[MandatoryPlaceholder](../../../Core/Objects/MandatoryPlaceholder/readme.md)|
|[ConnectsTo](../../ReferenceTypes/ConnectsTo/readme.md)|Object|[&lt;CPIdentifier&gt;](#&lt;CPIdentifier&gt;)||[ConnectionPointType](../../ObjectTypes/ConnectionPointType/readme.md)|[OptionalPlaceholder](../../../Core/Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Lock](#Lock)||[LockingServicesType](../../ObjectTypes/LockingServicesType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|


