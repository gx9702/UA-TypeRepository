<!-- datatype -->
## ServerState
<!-- end of description -->
The fields of the ServerState DataType are defined in the following table:  

|Name|Value| Description|
|---|---|---|
|Running|0||
|Failed|1||
|NoConfiguration|2||
|Suspended|3||
|Shutdown|4||
|Test|5||
|CommunicationFault|6||
|Unknown|7||

The representation of the ServerState DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|ServerState|
|IsAbtract|False|
|BaseType|[Enumeration](../../../Part3/DataTypes/Enumeration/readme.md)|

The references from the ServerState DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|EnumStrings||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

