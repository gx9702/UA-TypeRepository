<!-- datatype -->
## MessageSecurityMode
The type of security to use on a message.  
<!-- end of description -->
The fields of the MessageSecurityMode DataType are defined in the following table:  

|Name|Value| Description|
|---|---|---|
|Invalid|0|An invalid mode.|
|None|1|No security is used.|
|Sign|2|The message is signed.|
|SignAndEncrypt|3|The message is signed and encrypted.|

The representation of the MessageSecurityMode DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=302|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|MessageSecurityMode|
|IsAbstract|False|
|BaseType|[Enumeration](../../DataTypes/Enumeration/readme.md)|
|Categories||

The references from the MessageSecurityMode DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|EnumStrings|[LocalizedText](../../DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

