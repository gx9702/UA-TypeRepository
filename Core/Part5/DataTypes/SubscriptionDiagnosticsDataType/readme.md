<!-- datatype -->
## SubscriptionDiagnosticsDataType
  
<!-- end of description -->
The fields of the SubscriptionDiagnosticsDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|SubscriptionDiagnosticsDataType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;sessionId|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;subscriptionId|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;priority|[Byte](../../../Part3/DataTypes/Byte/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;publishingInterval|[Double](../../../Part3/DataTypes/Double/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;maxKeepAliveCount|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;maxLifetimeCount|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;maxNotificationsPerPublish|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;publishingEnabled|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;modifyCount|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;enableCount|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;disableCount|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;republishRequestCount|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;republishMessageRequestCount|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;republishMessageCount|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;transferRequestCount|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;transferredToAltClientCount|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;transferredToSameClientCount|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;publishRequestCount|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;dataChangeNotificationsCount|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;eventNotificationsCount|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;notificationsCount|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;latePublishRequestCount|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;currentKeepAliveCount|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;currentLifetimeCount|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;unacknowledgedMessageCount|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;discardedMessageCount|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;monitoredItemCount|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;disabledMonitoredItemCount|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;monitoringQueueOverflowCount|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;nextSequenceNumber|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;eventQueueOverFlowCount|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||

The representation of the SubscriptionDiagnosticsDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=874|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|SubscriptionDiagnosticsDataType|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part5|

