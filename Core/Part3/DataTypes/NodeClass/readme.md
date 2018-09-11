<!-- datatype -->
## NodeClass
A mask specifying the class of the node.  
<!-- end of description -->
The fields of the NodeClass DataType are defined in the following table:  

|Name|Value| Description|
|---|---|---|
|Unspecified|0|No classes are selected.|
|Object|1|The node is an object.|
|Variable|2|The node is a variable.|
|Method|4|The node is a method.|
|ObjectType|8|The node is an object type.|
|VariableType|16|The node is an variable type.|
|ReferenceType|32|The node is a reference type.|
|DataType|64|The node is a data type.|
|View|128|The node is a view.|

The representation of the NodeClass DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=257|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|NodeClass|
|IsAbstract|False|
|BaseType|[Enumeration](../../../Part3/DataTypes/Enumeration/readme.md)|
|Categories|Part3|

The references from the NodeClass DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|EnumValues|[EnumValueType](../../../Part3/DataTypes/EnumValueType/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

