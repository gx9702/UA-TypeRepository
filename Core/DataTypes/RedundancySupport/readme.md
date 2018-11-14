<!-- datatype -->
## RedundancySupport
  
<!-- end of description -->
The fields of the RedundancySupport DataType are defined in the following table:  

|Name|Value| Description|
|---|---|---|
|None|0||
|Cold|1||
|Warm|2||
|Hot|3||
|Transparent|4||
|HotAndMirrored|5||

The representation of the RedundancySupport DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=851|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|RedundancySupport|
|IsAbstract|False|
|BaseType|[Enumeration](../../DataTypes/Enumeration/readme.md)|
|Categories||

The references from the RedundancySupport DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|EnumStrings|[LocalizedText](../../DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

