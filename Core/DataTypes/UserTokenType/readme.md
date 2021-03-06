<!-- datatype -->
## UserTokenType
The possible user token types.  
<!-- end of description -->
The fields of the UserTokenType DataType are defined in the following table:  

|Name|Value| Description|
|---|---|---|
|Anonymous|0|An anonymous user.|
|UserName|1|A user identified by a user name and password.|
|Certificate|2|A user identified by an X509 certificate.|
|IssuedToken|3|A user identified by WS-Security XML token.|

The representation of the UserTokenType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=303|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|UserTokenType|
|IsAbstract|False|
|BaseType|[Enumeration](../../DataTypes/Enumeration/readme.md)|
|Categories||

The references from the UserTokenType DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|EnumStrings|[LocalizedText](../../DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

