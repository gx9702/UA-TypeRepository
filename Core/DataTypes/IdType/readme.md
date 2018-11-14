<!-- datatype -->
## IdType
The type of identifier used in a node id.  
<!-- end of description -->
The fields of the IdType DataType are defined in the following table:  

|Name|Value| Description|
|---|---|---|
|Numeric|0|The identifier is a numeric value. 0 is a null value.|
|String|1|The identifier is a string value. An empty string is a null value.|
|Guid|2|The identifier is a 16 byte structure. 16 zero bytes is a null value.|
|Opaque|3|The identifier is an array of bytes. A zero length array is a null value.|

The representation of the IdType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=256|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|IdType|
|IsAbstract|False|
|BaseType|[Enumeration](../../DataTypes/Enumeration/readme.md)|
|Categories||

The references from the IdType DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|EnumStrings|[LocalizedText](../../DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

