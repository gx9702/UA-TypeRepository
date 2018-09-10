<!-- objecttype -->
## ServerStatusType
The representation of the ServerStatusType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|ServerStatusType|
|NodeClass|VariableType|
|IsAbtract|False|
|BaseType|[BaseDataVariableType](../../../Part5/VariableTypes/BaseDataVariableType/readme.md)|

The references from the ServerStatusType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|StartTime|[UtcTime](../../../Part3/DataTypes/UtcTime/readme.md)|[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|CurrentTime|[UtcTime](../../../Part3/DataTypes/UtcTime/readme.md)|[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|State|[ServerState](../../../Part5/DataTypes/ServerState/readme.md)|[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|BuildInfo|[BuildInfo](../../../Part5/DataTypes/BuildInfo/readme.md)|[BuildInfoType](../../Part5/VariableTypes/BuildInfoType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|SecondsTillShutdown|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|ShutdownReason|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)|[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

