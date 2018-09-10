<!-- datatype -->
## MessageSecurityMode
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
|BrowseName|MessageSecurityMode|
|IsAbtract|False|
|BaseType|[Enumeration](../../../Part3/DataTypes/Enumeration/readme.md)|

The references from the MessageSecurityMode DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|EnumStrings|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

