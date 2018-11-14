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
|BaseType|[Enumeration](../../DataTypes/Enumeration/readme.md)|
|Categories||

The references from the StructureType DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|EnumStrings|[LocalizedText](../../DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

