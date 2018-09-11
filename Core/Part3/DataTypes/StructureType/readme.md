<!-- datatype -->
## StructureType
  
<!-- end of description -->
The fields of the StructureType DataType are defined in the following table:  

|Name|Value| Description|
|---|---|---|
|Structure|0||
|StructureWithOptionalFields|1||
|Union|2||

The representation of the StructureType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=98|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|StructureType|
|IsAbstract|False|
|BaseType|[Enumeration](../../../Part3/DataTypes/Enumeration/readme.md)|
|Categories|Part3|

The references from the StructureType DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|EnumStrings|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

