<!-- objecttype -->
## ArrayItemType
  
The representation of the ArrayItemType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|ArrayItemType|
|NodeClass|VariableType|
|IsAbtract|True|
|BaseType|[DataItemType](../../../Part8/VariableTypes/DataItemType/readme.md)|

The references from the ArrayItemType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[InstrumentRange](#InstrumentRange)|[Range](../../../Part8/DataTypes/Range/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[EURange](#EURange)|[Range](../../../Part8/DataTypes/Range/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[EngineeringUnits](#EngineeringUnits)|[EUInformation](../../../Part8/DataTypes/EUInformation/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[Title](#Title)|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[AxisScaleType](#AxisScaleType)|[AxisScaleEnumeration](../../../Part8/DataTypes/AxisScaleEnumeration/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|VariableType|[YArrayItemType](#YArrayItemType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|VariableType|[XYArrayItemType](#XYArrayItemType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|VariableType|[ImageItemType](#ImageItemType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|VariableType|[CubeItemType](#CubeItemType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|VariableType|[NDimensionArrayItemType](#NDimensionArrayItemType)||||


