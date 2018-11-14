<!-- objecttype -->
## TwoStateVariableType
  
<!-- end of text -->
The representation of the TwoStateVariableType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=8995|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|TwoStateVariableType|
|NodeClass|VariableType|
|DataType|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|
|ValueRank|-1|
|IsAbstract|False|
|BaseType|[StateVariableType](../../VariableTypes/StateVariableType/readme.md)|
|Categories||

The references from the TwoStateVariableType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[Id](#Id)|[Boolean](../../DataTypes/Boolean/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[TransitionTime](#TransitionTime)|[UtcTime](../../DataTypes/UtcTime/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[EffectiveTransitionTime](#EffectiveTransitionTime)|[UtcTime](../../DataTypes/UtcTime/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[TrueState](#TrueState)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[FalseState](#FalseState)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|


