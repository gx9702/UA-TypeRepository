<!-- objecttype -->
## MTConditionType
  
<!-- end of text -->
The representation of the MTConditionType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|ns=1;i=2573|
|NamespaceUri|http://opcfoundation.org/UA/MTConnect/v2|
|BrowseName|MTConditionType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[ConditionType](../../../Core/Part9/ObjectTypes/ConditionType/readme.md)|
|Categories||

The references from the MTConditionType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[XmlId](#XmlId)|[String](../../../Core/Part3/DataTypes/String/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[Name](#Name)|[String](../../../Core/Part3/DataTypes/String/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[Category](#Category)|[MTCategoryType](../../DataTypes/MTCategoryType/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[MTTypeName](#MTTypeName)|[String](../../../Core/Part3/DataTypes/String/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[MTSubTypeName](#MTSubTypeName)|[String](../../../Core/Part3/DataTypes/String/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[SourceData](#SourceData)|[String](../../../Core/Part3/DataTypes/String/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[SampleRate](#SampleRate)|[Double](../../../Core/Part3/DataTypes/Double/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[Representation](#Representation)|[MTRepresentationType](../../DataTypes/MTRepresentationType/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[PeriodFilter](#PeriodFilter)|[Float](../../../Core/Part3/DataTypes/Float/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Constraints](#Constraints)||[MTConstraintType](../../ObjectTypes/MTConstraintType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[NativeCode](#NativeCode)|[String](../../../Core/Part3/DataTypes/String/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[NativeSeverity](#NativeSeverity)|[String](../../../Core/Part3/DataTypes/String/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[MTSeverity](#MTSeverity)|[MTSeverityDataType](../../DataTypes/MTSeverityDataType/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[Qualifier](#Qualifier)|[QualifierDataType](../../DataTypes/QualifierDataType/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[ActiveState](#ActiveState)|[LocalizedText](../../../Core/Part3/DataTypes/LocalizedText/readme.md)|[TwoStateVariableType](../../../Core/Part9/VariableTypes/TwoStateVariableType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|

