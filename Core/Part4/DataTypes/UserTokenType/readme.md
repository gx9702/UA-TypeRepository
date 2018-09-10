<!-- datatype -->
## UserTokenType
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
|BrowseName|UserTokenType|
|IsAbtract|False|
|BaseType|[Enumeration](../../../Part3/DataTypes/Enumeration/readme.md)|

The references from the UserTokenType DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|EnumStrings|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

