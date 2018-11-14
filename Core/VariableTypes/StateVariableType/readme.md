<!-- objecttype -->
## StateVariableType
  
<!-- end of text -->
The representation of the StateVariableType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2755|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|StateVariableType|
|NodeClass|VariableType|
|DataType|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|
|ValueRank|-1|
|IsAbstract|False|
|BaseType|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|
|Categories||

The references from the StateVariableType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[Id](#Id)|[BaseDataType](../../DataTypes/BaseDataType/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[Name](#Name)|[QualifiedName](../../DataTypes/QualifiedName/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[Number](#Number)|[UInt32](../../DataTypes/UInt32/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[EffectiveDisplayName](#EffectiveDisplayName)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|VariableType|[FiniteStateVariableType](#FiniteStateVariableType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|VariableType|[TwoStateVariableType](#TwoStateVariableType)||||


