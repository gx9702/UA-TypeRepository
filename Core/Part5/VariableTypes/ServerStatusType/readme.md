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
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|StartTime||[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|CurrentTime||[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|State||[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|BuildInfo||[BuildInfoType](../../Part5/VariableTypes/BuildInfoType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|SecondsTillShutdown||[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|ShutdownReason||[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

