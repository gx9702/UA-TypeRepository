<!-- objecttype -->
## MTAssetEventType
  
<!-- end of text -->
The representation of the MTAssetEventType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|ns=1;i=2546|
|NamespaceUri|http://opcfoundation.org/UA/MTConnect/v2/|
|BrowseName|MTAssetEventType|
|NodeClass|VariableType|
|DataType|[AssetEventDataType](../../DataTypes/AssetEventDataType/readme.md)|
|ValueRank|-1|
|IsAbstract|False|
|BaseType|[BaseDataVariableType](../../../Core/VariableTypes/BaseDataVariableType/readme.md)|
|Categories||

The references from the MTAssetEventType VariableType Node are shown in the following table:  

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


