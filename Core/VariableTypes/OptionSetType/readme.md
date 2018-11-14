<!-- objecttype -->
## OptionSetType
  
<!-- end of text -->
The representation of the OptionSetType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=11487|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|OptionSetType|
|NodeClass|VariableType|
|DataType|[BaseDataType](../../DataTypes/BaseDataType/readme.md)|
|ValueRank|-1|
|IsAbstract|False|
|BaseType|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|
|Categories||

The references from the OptionSetType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[OptionSetValues](#OptionSetValues)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[BitMask](#BitMask)|[Boolean](../../DataTypes/Boolean/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|


