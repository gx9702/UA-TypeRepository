<!-- objecttype -->
## AccessoryType
The representation of the AccessoryType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|AccessoryType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[TopologyElementType](../../../DI/ObjectTypes/TopologyElementType/readme.md)|

The references from the AccessoryType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|Configuration||[FunctionalGroupType](../../../DI/ObjectTypes/FunctionalGroupType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|Status||[FunctionalGroupType](../../../DI/ObjectTypes/FunctionalGroupType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|FactorySettings||[FunctionalGroupType](../../../DI/ObjectTypes/FunctionalGroupType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|IsHotSwappable|[Boolean](../../../Core/Part3/DataTypes/Boolean/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|IsReady|[Boolean](../../../Core/Part3/DataTypes/Boolean/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasSubtype](../../../Core/Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|DetectorType||||
|[HasSubtype](../../../Core/Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|SmartSamplingSystemType||||
|[HasSubtype](../../../Core/Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|SourceType||||
|[HasSubtype](../../../Core/Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|GcOvenType||||

