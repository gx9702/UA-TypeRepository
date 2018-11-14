<!-- objecttype -->
## SessionDiagnosticsVariableType
  
<!-- end of text -->
The representation of the SessionDiagnosticsVariableType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2197|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|SessionDiagnosticsVariableType|
|NodeClass|VariableType|
|DataType|[SessionDiagnosticsDataType](../../DataTypes/SessionDiagnosticsDataType/readme.md)|
|ValueRank|-1|
|IsAbstract|False|
|BaseType|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|
|Categories||

The references from the SessionDiagnosticsVariableType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[SessionId](#SessionId)|[NodeId](../../DataTypes/NodeId/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[SessionName](#SessionName)|[String](../../DataTypes/String/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[ClientDescription](#ClientDescription)|[ApplicationDescription](../../DataTypes/ApplicationDescription/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[ServerUri](#ServerUri)|[String](../../DataTypes/String/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[EndpointUrl](#EndpointUrl)|[String](../../DataTypes/String/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[LocaleIds](#LocaleIds)|[LocaleId](../../DataTypes/LocaleId/readme.md)[]|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[ActualSessionTimeout](#ActualSessionTimeout)|[Duration](../../DataTypes/Duration/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[MaxResponseMessageSize](#MaxResponseMessageSize)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[ClientConnectionTime](#ClientConnectionTime)|[UtcTime](../../DataTypes/UtcTime/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[ClientLastContactTime](#ClientLastContactTime)|[UtcTime](../../DataTypes/UtcTime/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[CurrentSubscriptionsCount](#CurrentSubscriptionsCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[CurrentMonitoredItemsCount](#CurrentMonitoredItemsCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[CurrentPublishRequestsInQueue](#CurrentPublishRequestsInQueue)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[TotalRequestCount](#TotalRequestCount)|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[UnauthorizedRequestCount](#UnauthorizedRequestCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[ReadCount](#ReadCount)|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[HistoryReadCount](#HistoryReadCount)|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[WriteCount](#WriteCount)|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[HistoryUpdateCount](#HistoryUpdateCount)|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[CallCount](#CallCount)|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[CreateMonitoredItemsCount](#CreateMonitoredItemsCount)|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[ModifyMonitoredItemsCount](#ModifyMonitoredItemsCount)|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[SetMonitoringModeCount](#SetMonitoringModeCount)|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[SetTriggeringCount](#SetTriggeringCount)|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[DeleteMonitoredItemsCount](#DeleteMonitoredItemsCount)|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[CreateSubscriptionCount](#CreateSubscriptionCount)|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[ModifySubscriptionCount](#ModifySubscriptionCount)|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[SetPublishingModeCount](#SetPublishingModeCount)|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[PublishCount](#PublishCount)|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[RepublishCount](#RepublishCount)|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[TransferSubscriptionsCount](#TransferSubscriptionsCount)|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[DeleteSubscriptionsCount](#DeleteSubscriptionsCount)|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[AddNodesCount](#AddNodesCount)|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[AddReferencesCount](#AddReferencesCount)|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[DeleteNodesCount](#DeleteNodesCount)|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[DeleteReferencesCount](#DeleteReferencesCount)|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[BrowseCount](#BrowseCount)|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[BrowseNextCount](#BrowseNextCount)|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[TranslateBrowsePathsToNodeIdsCount](#TranslateBrowsePathsToNodeIdsCount)|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[QueryFirstCount](#QueryFirstCount)|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[QueryNextCount](#QueryNextCount)|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[RegisterNodesCount](#RegisterNodesCount)|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[UnregisterNodesCount](#UnregisterNodesCount)|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

