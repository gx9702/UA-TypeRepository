<!-- datatype -->
## BrowseResultMask
A bit mask which specifies what should be returned in a browse response.  
<!-- end of description -->
The fields of the BrowseResultMask DataType are defined in the following table:  

|Name|Value| Description|
|---|---|---|
|None|0|Return only the node id.|
|ReferenceTypeId|1|Return the reference type id.|
|IsForward|2|Return the flag indicating whether the reference is a forward reference.|
|NodeClass|4|Return the node class.|
|BrowseName|8|Return the browse name.|
|DisplayName|16|Return the display name.|
|TypeDefinition|32|Return the type definition.|
|All|63|Return all fields.|
|ReferenceTypeInfo|3|Return the reference type information.|
|TargetInfo|60|Return the information about the target node.|

The representation of the BrowseResultMask DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|BrowseResultMask|
|IsAbtract|False|
|BaseType|[Enumeration](../../../Part3/DataTypes/Enumeration/readme.md)|

The references from the BrowseResultMask DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|EnumValues|[EnumValueType](../../../Part3/DataTypes/EnumValueType/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

