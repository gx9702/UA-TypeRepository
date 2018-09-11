<!-- objecttype -->
## SelectionListType
  
<!-- end of text -->
The representation of the SelectionListType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=16309|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|SelectionListType|
|NodeClass|VariableType|
|DataType|[BaseDataType](../../../Part3/DataTypes/BaseDataType/readme.md)|
|ValueRank|-2|
|IsAbstract|False|
|BaseType|[BaseDataVariableType](../../../Part5/VariableTypes/BaseDataVariableType/readme.md)|
|Categories|Part5|

The references from the SelectionListType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[Selections](#Selections)|[BaseDataType](../../../Part3/DataTypes/BaseDataType/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[SelectionDescriptions](#SelectionDescriptions)|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[RestrictToList](#RestrictToList)|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|


