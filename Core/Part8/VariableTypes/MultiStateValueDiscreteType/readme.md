<!-- objecttype -->
## MultiStateValueDiscreteType
This VariableType defines the general characteristics of a DiscreteItem that can have more than two states and where the state values (the enumeration) does not consist of consecutive numeric values (may have gaps) or where the enumeration is not zero-based. The MultiStateValueDiscreteType derives from the DiscreteItemType. It is formally defined in Table 6.  
The representation of the MultiStateValueDiscreteType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|MultiStateValueDiscreteType|
|NodeClass|VariableType|
|IsAbtract|False|
|BaseType|[DiscreteItemType](../../../Part8/VariableTypes/DiscreteItemType/readme.md)|

The references from the MultiStateValueDiscreteType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[EnumValues](#EnumValues)|[EnumValueType](../../../Part3/DataTypes/EnumValueType/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ValueAsText](#ValueAsText)|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


