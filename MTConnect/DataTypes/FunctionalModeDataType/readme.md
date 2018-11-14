<!-- datatype -->
## FunctionalModeDataType
  
<!-- end of description -->
The fields of the FunctionalModeDataType DataType are defined in the following table:  

|Name|Value| Description|
|---|---|---|
|MAINTENANCE|0||
|PRODUCTION|1||
|PROCESS_DEVELOPMENT|2||
|SETUP|3||
|TEARDOWN|4||

The representation of the FunctionalModeDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|ns=1;i=2140|
|NamespaceUri|http://opcfoundation.org/UA/MTConnect/v2/|
|BrowseName|FunctionalModeDataType|
|IsAbstract|False|
|BaseType|[Enumeration](../../../Core/DataTypes/Enumeration/readme.md)|
|Categories||

The references from the FunctionalModeDataType DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Core/ReferenceTypes/HasProperty/readme.md)|Variable|EnumStrings|[LocalizedText](../../../Core/DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../../Core/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|

