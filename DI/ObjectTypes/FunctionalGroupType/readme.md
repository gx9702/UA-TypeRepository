<!-- objecttype -->
## FunctionalGroupType
FolderType is used to organize the Parameters and Methods from the complete set (ParameterSet, MethodSet) with regard to their application  
<!-- end of text -->
The representation of the FunctionalGroupType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|ns=1;i=1005|
|NamespaceUri|http://opcfoundation.org/UA/DI/|
|BrowseName|FunctionalGroupType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[FolderType](../../../Core/Part5/ObjectTypes/FolderType/readme.md)|
|Categories||

The references from the FunctionalGroupType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[&lt;GroupIdentifier&gt;](#&lt;GroupIdentifier&gt;)||[FunctionalGroupType](../../ObjectTypes/FunctionalGroupType/readme.md)|[OptionalPlaceholder](../../../Core/Objects/OptionalPlaceholder/readme.md)|
|[Organizes](../../../Core/Part3/ReferenceTypes/Organizes/readme.md)|Variable|[&lt;ParameterIdentifier&gt;](#&lt;ParameterIdentifier&gt;)|[BaseDataType](../../../Core/Part3/DataTypes/BaseDataType/readme.md)|[BaseDataVariableType](../../../Core/Part5/VariableTypes/BaseDataVariableType/readme.md)|[OptionalPlaceholder](../../../Core/Objects/OptionalPlaceholder/readme.md)|
|[Organizes](../../../Core/Part3/ReferenceTypes/Organizes/readme.md)|Method|[&lt;MethodIdentifier&gt;](#&lt;MethodIdentifier&gt;)||||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[UIElement](#UIElement)|[BaseDataType](../../../Core/Part3/DataTypes/BaseDataType/readme.md)|[UIElementType](../../VariableTypes/UIElementType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|


