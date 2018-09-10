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
|BrowseName|SecurityTokenRequestType|
|IsAbtract|False|
|BaseType|[Enumeration](../../../Part3/DataTypes/Enumeration/readme.md)|

The references from the SecurityTokenRequestType DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|EnumStrings|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

