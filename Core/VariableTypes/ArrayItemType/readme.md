<!-- objecttype -->
## ArrayItemType
  
<!-- end of text -->
The representation of the ArrayItemType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=12021|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|ArrayItemType|
|NodeClass|VariableType|
|DataType|[BaseDataType](../../DataTypes/BaseDataType/readme.md)|
|ValueRank|0|
|IsAbstract|True|
|BaseType|[DataItemType](../../VariableTypes/DataItemType/readme.md)|
|Categories||

The references from the ArrayItemType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[InstrumentRange](#InstrumentRange)|[Range](../../DataTypes/Range/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[EURange](#EURange)|[Range](../../DataTypes/Range/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[EngineeringUnits](#EngineeringUnits)|[EUInformation](../../DataTypes/EUInformation/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[Title](#Title)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[AxisScaleType](#AxisScaleType)|[AxisScaleEnumeration](../../DataTypes/AxisScaleEnumeration/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|VariableType|[YArrayItemType](#YArrayItemType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|VariableType|[XYArrayItemType](#XYArrayItemType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|VariableType|[ImageItemType](#ImageItemType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|VariableType|[CubeItemType](#CubeItemType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|VariableType|[NDimensionArrayItemType](#NDimensionArrayItemType)||||


