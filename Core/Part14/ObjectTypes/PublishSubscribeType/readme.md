<!-- objecttype -->
## PublishSubscribeType
The representation of the PublishSubscribeType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|PublishSubscribeType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[PubSubKeyServiceType](../../../Part14/ObjectTypes/PubSubKeyServiceType/readme.md)|

The references from the PublishSubscribeType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasPubSubConnection](../../../Part14/ReferenceTypes/HasPubSubConnection/readme.md)|Object|&lt;ConnectionName&gt;||[PubSubConnectionType](../../Part14/ObjectTypes/PubSubConnectionType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|SetSecurityKeys|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|AddConnection|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|RemoveConnection|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|PublishedDataSets||[DataSetFolderType](../../Part14/ObjectTypes/DataSetFolderType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|Status||[PubSubStatusType](../../Part14/ObjectTypes/PubSubStatusType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|Diagnostics||[PubSubDiagnosticsRootType](../../Part14/ObjectTypes/PubSubDiagnosticsRootType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|SupportedTransportProfiles||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

