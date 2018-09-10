<!-- objecttype -->
## OptionSetType
  
The representation of the OptionSetType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|OptionSetType|
|NodeClass|VariableType|
|IsAbtract|False|
|BaseType|[BaseDataVariableType](../../../Part5/VariableTypes/BaseDataVariableType/readme.md)|

The references from the OptionSetType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[OptionSetValues](#OptionSetValues)|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[BitMask](#BitMask)|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|

