<!-- datatype -->
## InterfaceStateDataType
  
<!-- end of description -->
The fields of the InterfaceStateDataType DataType are defined in the following table:  

|Name|Value| Description|
|---|---|---|
|ACTIVE|0||
|COMPLETE|1||
|FAIL|2||
|NOT_READY|4||
|READY|5||

The representation of the InterfaceStateDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|ns=1;i=2166|
|NamespaceUri|http://opcfoundation.org/UA/MTConnect/v2/|
|BrowseName|InterfaceStateDataType|
|IsAbstract|False|
|BaseType|[Enumeration](../../../Core/DataTypes/Enumeration/readme.md)|
|Categories||

The references from the InterfaceStateDataType DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Core/ReferenceTypes/HasProperty/readme.md)|Variable|EnumStrings|[LocalizedText](../../../Core/DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../../Core/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|

