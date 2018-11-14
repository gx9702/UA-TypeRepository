<!-- objecttype -->
## MTSampleType
  
<!-- end of text -->
The representation of the MTSampleType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|ns=1;i=2353|
|NamespaceUri|http://opcfoundation.org/UA/MTConnect/v2/|
|BrowseName|MTSampleType|
|NodeClass|VariableType|
|DataType|[Number](../../../Core/DataTypes/Number/readme.md)|
|ValueRank|-1|
|IsAbstract|False|
|BaseType|[AnalogUnitType](../../../Core/VariableTypes/AnalogUnitType/readme.md)|
|Categories||

The references from the MTSampleType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Core/ReferenceTypes/HasProperty/readme.md)|Variable|[XmlId](#XmlId)|[String](../../../Core/DataTypes/String/readme.md)|[PropertyType](../../../Core/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasProperty](../../../Core/ReferenceTypes/HasProperty/readme.md)|Variable|[Name](#Name)|[String](../../../Core/DataTypes/String/readme.md)|[PropertyType](../../../Core/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/ReferenceTypes/HasProperty/readme.md)|Variable|[Category](#Category)|[MTCategoryType](../../DataTypes/MTCategoryType/readme.md)|[PropertyType](../../../Core/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasProperty](../../../Core/ReferenceTypes/HasProperty/readme.md)|Variable|[MTTypeName](#MTTypeName)|[String](../../../Core/DataTypes/String/readme.md)|[PropertyType](../../../Core/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasProperty](../../../Core/ReferenceTypes/HasProperty/readme.md)|Variable|[MTSubTypeName](#MTSubTypeName)|[String](../../../Core/DataTypes/String/readme.md)|[PropertyType](../../../Core/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/ReferenceTypes/HasProperty/readme.md)|Variable|[SourceData](#SourceData)|[String](../../../Core/DataTypes/String/readme.md)|[PropertyType](../../../Core/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/ReferenceTypes/HasProperty/readme.md)|Variable|[SampleRate](#SampleRate)|[Double](../../../Core/DataTypes/Double/readme.md)|[PropertyType](../../../Core/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/ReferenceTypes/HasProperty/readme.md)|Variable|[Representation](#Representation)|[MTRepresentationType](../../DataTypes/MTRepresentationType/readme.md)|[PropertyType](../../../Core/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/ReferenceTypes/HasProperty/readme.md)|Variable|[PeriodFilter](#PeriodFilter)|[Float](../../../Core/DataTypes/Float/readme.md)|[PropertyType](../../../Core/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasComponent](../../../Core/ReferenceTypes/HasComponent/readme.md)|Object|[Constraints](#Constraints)||[MTConstraintType](../../ObjectTypes/MTConstraintType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/ReferenceTypes/HasProperty/readme.md)|Variable|[SignificantDigits](#SignificantDigits)|[UInt16](../../../Core/DataTypes/UInt16/readme.md)|[PropertyType](../../../Core/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/ReferenceTypes/HasProperty/readme.md)|Variable|[Statistic](#Statistic)|[String](../../../Core/DataTypes/String/readme.md)|[PropertyType](../../../Core/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/ReferenceTypes/HasProperty/readme.md)|Variable|[NativeUnits](#NativeUnits)|[String](../../../Core/DataTypes/String/readme.md)|[PropertyType](../../../Core/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/ReferenceTypes/HasProperty/readme.md)|Variable|[CoordinateSystem](#CoordinateSystem)|[CoordinateSystemType](../../DataTypes/CoordinateSystemType/readme.md)|[PropertyType](../../../Core/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/ReferenceTypes/HasProperty/readme.md)|Variable|[InitialValue](#InitialValue)|[Double](../../../Core/DataTypes/Double/readme.md)|[PropertyType](../../../Core/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/ReferenceTypes/HasProperty/readme.md)|Variable|[ResetTrigger](#ResetTrigger)|[DataItemResetValueType](../../DataTypes/DataItemResetValueType/readme.md)|[PropertyType](../../../Core/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/ReferenceTypes/HasProperty/readme.md)|Variable|[Units](#Units)|[String](../../../Core/DataTypes/String/readme.md)|[PropertyType](../../../Core/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/ReferenceTypes/HasProperty/readme.md)|Variable|[MinimumDeltaFilter](#MinimumDeltaFilter)|[Float](../../../Core/DataTypes/Float/readme.md)|[PropertyType](../../../Core/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|


