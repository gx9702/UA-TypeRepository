<!-- datatype -->
## SessionDiagnosticsDataType
  
<!-- end of description -->
The fields of the SessionDiagnosticsDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|SessionDiagnosticsDataType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;sessionId|[NodeId](../../DataTypes/NodeId/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;sessionName|[String](../../DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;clientDescription|[ApplicationDescription](../../DataTypes/ApplicationDescription/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;serverUri|[String](../../DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;endpointUrl|[String](../../DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;localeIds|[LocaleId](../../DataTypes/LocaleId/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;actualSessionTimeout|[Duration](../../DataTypes/Duration/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;maxResponseMessageSize|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;clientConnectionTime|[UtcTime](../../DataTypes/UtcTime/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;clientLastContactTime|[UtcTime](../../DataTypes/UtcTime/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;currentSubscriptionsCount|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;currentMonitoredItemsCount|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;currentPublishRequestsInQueue|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;totalRequestCount|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;unauthorizedRequestCount|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;readCount|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;historyReadCount|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;writeCount|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;historyUpdateCount|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;callCount|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;createMonitoredItemsCount|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;modifyMonitoredItemsCount|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;setMonitoringModeCount|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;setTriggeringCount|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;deleteMonitoredItemsCount|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;createSubscriptionCount|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;modifySubscriptionCount|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;setPublishingModeCount|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;publishCount|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;republishCount|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;transferSubscriptionsCount|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;deleteSubscriptionsCount|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;addNodesCount|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;addReferencesCount|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;deleteNodesCount|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;deleteReferencesCount|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;browseCount|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;browseNextCount|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;translateBrowsePathsToNodeIdsCount|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;queryFirstCount|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;queryNextCount|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;registerNodesCount|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;unregisterNodesCount|[ServiceCounterDataType](../../DataTypes/ServiceCounterDataType/readme.md)||

The representation of the SessionDiagnosticsDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=865|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|SessionDiagnosticsDataType|
|IsAbstract|False|
|BaseType|[Structure](../../DataTypes/Structure/readme.md)|
|Categories||

