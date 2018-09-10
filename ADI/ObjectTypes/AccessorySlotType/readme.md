<!-- objecttype -->
## AccessorySlotType
The representation of the AccessorySlotType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|AccessorySlotType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[ConfigurableObjectType](../../../DI/ObjectTypes/ConfigurableObjectType/readme.md)|

The references from the AccessorySlotType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|IsHotSwappable|[Boolean](../../../Core/Part3/DataTypes/Boolean/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|IsEnabled|[Boolean](../../../Core/Part3/DataTypes/Boolean/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|AccessorySlotStateMachine||[AccessorySlotStateMachineType](../../ObjectTypes/AccessorySlotStateMachineType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|&lt;AccessoryIdentifier&gt;||[AccessoryType](../../ObjectTypes/AccessoryType/readme.md)|[OptionalPlaceholder](../../../Core/Objects/OptionalPlaceholder/readme.md)|

