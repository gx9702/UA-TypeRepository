<!-- objecttype -->
## SubscriptionDiagnosticsType
  
<!-- end of text -->
The representation of the SubscriptionDiagnosticsType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2172|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|SubscriptionDiagnosticsType|
|NodeClass|VariableType|
|DataType|[SubscriptionDiagnosticsDataType](../../DataTypes/SubscriptionDiagnosticsDataType/readme.md)|
|ValueRank|-1|
|IsAbstract|False|
|BaseType|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|
|Categories||

The references from the SubscriptionDiagnosticsType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[SessionId](#SessionId)|[NodeId](../../DataTypes/NodeId/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[SubscriptionId](#SubscriptionId)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[Priority](#Priority)|[Byte](../../DataTypes/Byte/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[PublishingInterval](#PublishingInterval)|[Double](../../DataTypes/Double/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[MaxKeepAliveCount](#MaxKeepAliveCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[MaxLifetimeCount](#MaxLifetimeCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[MaxNotificationsPerPublish](#MaxNotificationsPerPublish)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[PublishingEnabled](#PublishingEnabled)|[Boolean](../../DataTypes/Boolean/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[ModifyCount](#ModifyCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[EnableCount](#EnableCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[DisableCount](#DisableCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[RepublishRequestCount](#RepublishRequestCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[RepublishMessageRequestCount](#RepublishMessageRequestCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[RepublishMessageCount](#RepublishMessageCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[TransferRequestCount](#TransferRequestCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[TransferredToAltClientCount](#TransferredToAltClientCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[TransferredToSameClientCount](#TransferredToSameClientCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[PublishRequestCount](#PublishRequestCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[DataChangeNotificationsCount](#DataChangeNotificationsCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[EventNotificationsCount](#EventNotificationsCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[NotificationsCount](#NotificationsCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[LatePublishRequestCount](#LatePublishRequestCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[CurrentKeepAliveCount](#CurrentKeepAliveCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[CurrentLifetimeCount](#CurrentLifetimeCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[UnacknowledgedMessageCount](#UnacknowledgedMessageCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[DiscardedMessageCount](#DiscardedMessageCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[MonitoredItemCount](#MonitoredItemCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[DisabledMonitoredItemCount](#DisabledMonitoredItemCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[MonitoringQueueOverflowCount](#MonitoringQueueOverflowCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[NextSequenceNumber](#NextSequenceNumber)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[EventQueueOverflowCount](#EventQueueOverflowCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


