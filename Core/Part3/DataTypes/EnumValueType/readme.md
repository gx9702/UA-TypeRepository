<!-- datatype -->
## EnumValueType
<!-- end of description -->
The fields of the EnumValueType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|EnumValueType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;value|[Int64](../../../Part3/DataTypes/Int64/readme.md)|The value of the enumeration.|
|&nbsp;&nbsp;&nbsp;&nbsp;displayName|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)|Human readable name for the value.|
|&nbsp;&nbsp;&nbsp;&nbsp;description|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)|A description of the value.|

The representation of the EnumValueType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|EnumValueType|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

The references from the EnumValueType DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|EnumField||||

