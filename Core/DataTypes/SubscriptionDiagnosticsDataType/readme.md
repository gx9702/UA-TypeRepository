<!-- datatype -->
## SubscriptionDiagnosticsDataType
  
<!-- end of description -->
The fields of the SubscriptionDiagnosticsDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|SubscriptionDiagnosticsDataType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;sessionId|[NodeId](../../DataTypes/NodeId/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;subscriptionId|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;priority|[Byte](../../DataTypes/Byte/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;publishingInterval|[Double](../../DataTypes/Double/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;maxKeepAliveCount|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;maxLifetimeCount|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;maxNotificationsPerPublish|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;publishingEnabled|[Boolean](../../DataTypes/Boolean/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;modifyCount|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;enableCount|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;disableCount|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;republishRequestCount|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;republishMessageRequestCount|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;republishMessageCount|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;transferRequestCount|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;transferredToAltClientCount|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;transferredToSameClientCount|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;publishRequestCount|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;dataChangeNotificationsCount|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;eventNotificationsCount|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;notificationsCount|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;latePublishRequestCount|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;currentKeepAliveCount|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;currentLifetimeCount|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;unacknowledgedMessageCount|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;discardedMessageCount|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;monitoredItemCount|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;disabledMonitoredItemCount|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;monitoringQueueOverflowCount|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;nextSequenceNumber|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;eventQueueOverFlowCount|[UInt32](../../DataTypes/UInt32/readme.md)||

The representation of the SubscriptionDiagnosticsDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=874|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|SubscriptionDiagnosticsDataType|
|IsAbstract|False|
|BaseType|[Structure](../../DataTypes/Structure/readme.md)|
|Categories||

