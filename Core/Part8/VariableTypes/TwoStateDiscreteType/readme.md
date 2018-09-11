<!-- objecttype -->
## TwoStateDiscreteType
This VariableType defines the general characteristics of a DiscreteItem that can have two states. The TwoStateDiscreteType derives from the DiscreteItemType. It is formally defined in Table 4.  
<!-- end of text -->
The representation of the TwoStateDiscreteType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2373|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|TwoStateDiscreteType|
|NodeClass|VariableType|
|DataType|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)|
|ValueRank|-2|
|IsAbstract|False|
|BaseType|[DiscreteItemType](../../../Part8/VariableTypes/DiscreteItemType/readme.md)|
|Categories|Part8|

The references from the TwoStateDiscreteType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[FalseState](#FalseState)|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[TrueState](#TrueState)|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


