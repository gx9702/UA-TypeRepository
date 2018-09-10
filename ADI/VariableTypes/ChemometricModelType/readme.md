<!-- objecttype -->
## ChemometricModelType
The representation of the ChemometricModelType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|ChemometricModelType|
|NodeClass|VariableType|
|IsAbtract|False|
|BaseType|[BaseDataVariableType](../../../Core/Part5/VariableTypes/BaseDataVariableType/readme.md)|

The references from the ChemometricModelType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|Name|[LocalizedText](../../../Core/Part3/DataTypes/LocalizedText/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|CreationDate|[DateTime](../../../Core/Part3/DataTypes/DateTime/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|ModelDescription|[LocalizedText](../../../Core/Part3/DataTypes/LocalizedText/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasInput](../../ReferenceTypes/HasInput/readme.md)|Variable|&lt;User defined Input#&gt;|[BaseDataType](../../../Core/Part3/DataTypes/BaseDataType/readme.md)|[BaseVariableType](../../../Core/Part5/VariableTypes/BaseVariableType/readme.md)|[MandatoryPlaceholder](../../../Core/Objects/MandatoryPlaceholder/readme.md)|
|[HasOutput](../../ReferenceTypes/HasOutput/readme.md)|Variable|&lt;User defined Output#&gt;|[BaseDataType](../../../Core/Part3/DataTypes/BaseDataType/readme.md)|[BaseVariableType](../../../Core/Part5/VariableTypes/BaseVariableType/readme.md)|[MandatoryPlaceholder](../../../Core/Objects/MandatoryPlaceholder/readme.md)|
|[HasSubtype](../../../Core/Part3/ReferenceTypes/HasSubtype/readme.md)|VariableType|MVAModelType||||

