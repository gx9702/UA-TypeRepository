<!-- objecttype -->
## BaseAnalogType
  
<!-- end of text -->
The representation of the BaseAnalogType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15318|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|BaseAnalogType|
|NodeClass|VariableType|
|DataType|[Number](../../DataTypes/Number/readme.md)|
|ValueRank|-2|
|IsAbstract|False|
|BaseType|[DataItemType](../../VariableTypes/DataItemType/readme.md)|
|Categories||

The references from the BaseAnalogType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[InstrumentRange](#InstrumentRange)|[Range](../../DataTypes/Range/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[EURange](#EURange)|[Range](../../DataTypes/Range/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[EngineeringUnits](#EngineeringUnits)|[EUInformation](../../DataTypes/EUInformation/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|VariableType|[AnalogItemType](#AnalogItemType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|VariableType|[AnalogUnitType](#AnalogUnitType)||||


