<!-- datatype -->
## SecurityTokenRequestType
Indicates whether a token if being created or renewed.  
<!-- end of description -->
The fields of the SecurityTokenRequestType DataType are defined in the following table:  

|Name|Value| Description|
|---|---|---|
|Issue|0|The channel is being created.|
|Renew|1|The channel is being renewed.|

The representation of the SecurityTokenRequestType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=315|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|SecurityTokenRequestType|
|IsAbstract|False|
|BaseType|[Enumeration](../../DataTypes/Enumeration/readme.md)|
|Categories||

The references from the SecurityTokenRequestType DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|EnumStrings|[LocalizedText](../../DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

