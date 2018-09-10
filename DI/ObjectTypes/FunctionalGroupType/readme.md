<!-- objecttype -->
## FunctionalGroupType
The representation of the FunctionalGroupType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|FunctionalGroupType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[FolderType](../../../Core/Part5/ObjectTypes/FolderType/readme.md)|

The references from the FunctionalGroupType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|&lt;GroupIdentifier&gt;||[FunctionalGroupType](../../ObjectTypes/FunctionalGroupType/readme.md)|[OptionalPlaceholder](../../../Core/Objects/OptionalPlaceholder/readme.md)|
|[Organizes](../../../Core/Part3/ReferenceTypes/Organizes/readme.md)|Variable|&lt;ParameterIdentifier&gt;||[BaseDataVariableType](../../../Core/Part5/VariableTypes/BaseDataVariableType/readme.md)|[OptionalPlaceholder](../../../Core/Objects/OptionalPlaceholder/readme.md)|
|[Organizes](../../../Core/Part3/ReferenceTypes/Organizes/readme.md)|Method|&lt;MethodIdentifier&gt;||||
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Variable|UIElement||[UIElementType](../../VariableTypes/UIElementType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|

