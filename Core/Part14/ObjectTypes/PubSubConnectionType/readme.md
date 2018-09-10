<!-- objecttype -->
## PubSubConnectionType
The representation of the PubSubConnectionType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|PubSubConnectionType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[BaseObjectType](../../../Part5/ObjectTypes/BaseObjectType/readme.md)|

The references from the PubSubConnectionType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|PublisherId||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|TransportProfileUri||[SelectionListType](../../Part5/VariableTypes/SelectionListType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|ConnectionProperties||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|Address||[NetworkAddressType](../../Part14/ObjectTypes/NetworkAddressType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|TransportSettings||[ConnectionTransportType](../../Part14/ObjectTypes/ConnectionTransportType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|&lt;WriterGroupName&gt;||[WriterGroupType](../../Part14/ObjectTypes/WriterGroupType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|&lt;ReaderGroupName&gt;||[ReaderGroupType](../../Part14/ObjectTypes/ReaderGroupType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|Status||[PubSubStatusType](../../Part14/ObjectTypes/PubSubStatusType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|Diagnostics||[PubSubDiagnosticsConnectionType](../../Part14/ObjectTypes/PubSubDiagnosticsConnectionType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|AddWriterGroup|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|AddReaderGroup|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|RemoveGroup|||[Optional](../../Objects/Optional/readme.md)|

