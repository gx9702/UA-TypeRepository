<!-- objecttype -->
## MultiStateDiscreteType
This VariableType defines the general characteristics of a DiscreteItem that can have more than two states. The MultiStateDiscreteType derives from the DiscreteItemType. It is formally defined in Table 5.  
The representation of the MultiStateDiscreteType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|MultiStateDiscreteType|
|NodeClass|VariableType|
|IsAbtract|False|
|BaseType|[DiscreteItemType](../../../Part8/VariableTypes/DiscreteItemType/readme.md)|

The references from the MultiStateDiscreteType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[EnumStrings](#EnumStrings)|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


