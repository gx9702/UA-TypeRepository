<!-- datatype -->
## ApplicationType
<!-- end of description -->
The fields of the ApplicationType DataType are defined in the following table:  

|Name|Value| Description|
|---|---|---|
|Server|0|The application is a server.|
|Client|1|The application is a client.|
|ClientAndServer|2|The application is a client and a server.|
|DiscoveryServer|3|The application is a discovery server.|

The representation of the ApplicationType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|ApplicationType|
|IsAbtract|False|
|BaseType|[Enumeration](../../../Part3/DataTypes/Enumeration/readme.md)|

The references from the ApplicationType DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|EnumStrings|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

