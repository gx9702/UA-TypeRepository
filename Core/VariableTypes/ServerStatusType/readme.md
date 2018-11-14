<!-- objecttype -->
## ServerStatusType
  
<!-- end of text -->
The representation of the ServerStatusType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2138|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|ServerStatusType|
|NodeClass|VariableType|
|DataType|[ServerStatusDataType](../../DataTypes/ServerStatusDataType/readme.md)|
|ValueRank|-1|
|IsAbstract|False|
|BaseType|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|
|Categories||

The references from the ServerStatusType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[StartTime](#StartTime)|[UtcTime](../../DataTypes/UtcTime/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[CurrentTime](#CurrentTime)|[UtcTime](../../DataTypes/UtcTime/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[State](#State)|[ServerState](../../DataTypes/ServerState/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[BuildInfo](#BuildInfo)|[BuildInfo](../../DataTypes/BuildInfo/readme.md)|[BuildInfoType](../../VariableTypes/BuildInfoType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[SecondsTillShutdown](#SecondsTillShutdown)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[ShutdownReason](#ShutdownReason)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


