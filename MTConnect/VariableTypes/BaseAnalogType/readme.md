<!-- objecttype -->
## BaseAnalogType
  
<!-- end of text -->
The representation of the BaseAnalogType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|ns=1;i=3242|
|NamespaceUri|http://opcfoundation.org/UA/MTConnect/v2|
|BrowseName|BaseAnalogType|
|NodeClass|VariableType|
|DataType|[Number](../../../Core/Part3/DataTypes/Number/readme.md)|
|ValueRank|-2|
|IsAbstract|False|
|BaseType|[DataItemType](../../../Core/Part8/VariableTypes/DataItemType/readme.md)|
|Categories||

The references from the BaseAnalogType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[InstrumentRange](#InstrumentRange)|[Range](../../../Core/Part8/DataTypes/Range/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[EURange](#EURange)|[Range](../../../Core/Part8/DataTypes/Range/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[EngineeringUnits](#EngineeringUnits)|[EUInformation](../../../Core/Part8/DataTypes/EUInformation/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasSubtype](../../../Core/Part3/ReferenceTypes/HasSubtype/readme.md)|VariableType|[AnalogUnitType](#AnalogUnitType)||||


