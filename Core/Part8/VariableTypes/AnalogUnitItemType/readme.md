<!-- objecttype -->
## AnalogUnitItemType

The representation of the AnalogUnitItemType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|AnalogUnitItemType|
|NodeClass|VariableType|
|IsAbtract|False|
|BaseType|[DataItemType](../../../Part8/VariableTypes/DataItemType/readme.md)|

The references from the AnalogUnitItemType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[InstrumentRange](#InstrumentRange)|[Range](../../../Part8/DataTypes/Range/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[EURange](#EURange)|[Range](../../../Part8/DataTypes/Range/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[EngineeringUnits](#EngineeringUnits)|[EUInformation](../../../Part8/DataTypes/EUInformation/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


