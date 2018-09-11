<!-- objecttype -->
## ChemometricModelType
Hold the descriptions of a mathematical process and associated information to convert scaled data into one or more process values.  
<!-- end of text -->
The representation of the ChemometricModelType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|ns=1;i=2007|
|NamespaceUri|http://opcfoundation.org/UA/ADI/|
|BrowseName|ChemometricModelType|
|NodeClass|VariableType|
|DataType|[ByteString](../../../Core/Part3/DataTypes/ByteString/readme.md)|
|ValueRank|-2|
|IsAbstract|False|
|BaseType|[BaseDataVariableType](../../../Core/Part5/VariableTypes/BaseDataVariableType/readme.md)|
|Categories||

The references from the ChemometricModelType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[Name](#Name)|[LocalizedText](../../../Core/Part3/DataTypes/LocalizedText/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[CreationDate](#CreationDate)|[DateTime](../../../Core/Part3/DataTypes/DateTime/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ModelDescription](#ModelDescription)|[LocalizedText](../../../Core/Part3/DataTypes/LocalizedText/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasInput](../../ReferenceTypes/HasInput/readme.md)|Variable|[&lt;User defined Input#&gt;](#&lt;User defined Input#&gt;)|[BaseDataType](../../../Core/Part3/DataTypes/BaseDataType/readme.md)|[BaseVariableType](../../../Core/Part5/VariableTypes/BaseVariableType/readme.md)|[MandatoryPlaceholder](../../../Core/Objects/MandatoryPlaceholder/readme.md)|
|[HasOutput](../../ReferenceTypes/HasOutput/readme.md)|Variable|[&lt;User defined Output#&gt;](#&lt;User defined Output#&gt;)|[BaseDataType](../../../Core/Part3/DataTypes/BaseDataType/readme.md)|[BaseVariableType](../../../Core/Part5/VariableTypes/BaseVariableType/readme.md)|[MandatoryPlaceholder](../../../Core/Objects/MandatoryPlaceholder/readme.md)|
|[HasSubtype](../../../Core/Part3/ReferenceTypes/HasSubtype/readme.md)|VariableType|[MVAModelType](#MVAModelType)||||


