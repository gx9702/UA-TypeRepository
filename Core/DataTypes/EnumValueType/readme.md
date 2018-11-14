<!-- datatype -->
## EnumValueType
A mapping between a value of an enumerated type and a name and description.  
<!-- end of description -->
The fields of the EnumValueType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|EnumValueType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;value|[Int64](../../DataTypes/Int64/readme.md)|The value of the enumeration.|
|&nbsp;&nbsp;&nbsp;&nbsp;displayName|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|Human readable name for the value.|
|&nbsp;&nbsp;&nbsp;&nbsp;description|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|A description of the value.|

The representation of the EnumValueType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=7594|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|EnumValueType|
|IsAbstract|False|
|BaseType|[Structure](../../DataTypes/Structure/readme.md)|
|Categories||

The references from the EnumValueType DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|DataType|EnumField||||

