<!-- objecttype -->
## ConnectionPointType
Represents the interface (interface card) of a Device to a Network.  
The representation of the ConnectionPointType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|ConnectionPointType|
|NodeClass|ObjectType|
|IsAbtract|True|
|BaseType|[TopologyElementType](../../ObjectTypes/TopologyElementType/readme.md)|

The references from the ConnectionPointType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[NetworkAddress](#NetworkAddress)||[FunctionalGroupType](../../ObjectTypes/FunctionalGroupType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[&lt;ProfileId&gt;](#&lt;ProfileId&gt;)||[ProtocolType](../../ObjectTypes/ProtocolType/readme.md)|[MandatoryPlaceholder](../../../Core/Objects/MandatoryPlaceholder/readme.md)|
|[ConnectsTo](../../ReferenceTypes/ConnectsTo/readme.md)|Object|[&lt;NetworkIdentifier&gt;](#&lt;NetworkIdentifier&gt;)||[NetworkType](../../ObjectTypes/NetworkType/readme.md)|[OptionalPlaceholder](../../../Core/Objects/OptionalPlaceholder/readme.md)|


