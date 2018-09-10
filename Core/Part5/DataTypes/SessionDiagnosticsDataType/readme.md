<!-- datatype -->
## SessionDiagnosticsDataType
<!-- end of description -->
The fields of the SessionDiagnosticsDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|SessionDiagnosticsDataType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;sessionId|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;sessionName|[String](../../../Part3/DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;clientDescription|[ApplicationDescription](../../../Part4/DataTypes/ApplicationDescription/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;serverUri|[String](../../../Part3/DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;endpointUrl|[String](../../../Part3/DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;localeIds|[LocaleId](../../../Part3/DataTypes/LocaleId/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;actualSessionTimeout|[Duration](../../../Part3/DataTypes/Duration/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;maxResponseMessageSize|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;clientConnectionTime|[UtcTime](../../../Part3/DataTypes/UtcTime/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;clientLastContactTime|[UtcTime](../../../Part3/DataTypes/UtcTime/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;currentSubscriptionsCount|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;currentMonitoredItemsCount|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;currentPublishRequestsInQueue|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;totalRequestCount|[ServiceCounterDataType](../../../Part5/DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;unauthorizedRequestCount|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;readCount|[ServiceCounterDataType](../../../Part5/DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;historyReadCount|[ServiceCounterDataType](../../../Part5/DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;writeCount|[ServiceCounterDataType](../../../Part5/DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;historyUpdateCount|[ServiceCounterDataType](../../../Part5/DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;callCount|[ServiceCounterDataType](../../../Part5/DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;createMonitoredItemsCount|[ServiceCounterDataType](../../../Part5/DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;modifyMonitoredItemsCount|[ServiceCounterDataType](../../../Part5/DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;setMonitoringModeCount|[ServiceCounterDataType](../../../Part5/DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;setTriggeringCount|[ServiceCounterDataType](../../../Part5/DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;deleteMonitoredItemsCount|[ServiceCounterDataType](../../../Part5/DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;createSubscriptionCount|[ServiceCounterDataType](../../../Part5/DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;modifySubscriptionCount|[ServiceCounterDataType](../../../Part5/DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;setPublishingModeCount|[ServiceCounterDataType](../../../Part5/DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;publishCount|[ServiceCounterDataType](../../../Part5/DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;republishCount|[ServiceCounterDataType](../../../Part5/DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;transferSubscriptionsCount|[ServiceCounterDataType](../../../Part5/DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;deleteSubscriptionsCount|[ServiceCounterDataType](../../../Part5/DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;addNodesCount|[ServiceCounterDataType](../../../Part5/DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;addReferencesCount|[ServiceCounterDataType](../../../Part5/DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;deleteNodesCount|[ServiceCounterDataType](../../../Part5/DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;deleteReferencesCount|[ServiceCounterDataType](../../../Part5/DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;browseCount|[ServiceCounterDataType](../../../Part5/DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;browseNextCount|[ServiceCounterDataType](../../../Part5/DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;translateBrowsePathsToNodeIdsCount|[ServiceCounterDataType](../../../Part5/DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;queryFirstCount|[ServiceCounterDataType](../../../Part5/DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;queryNextCount|[ServiceCounterDataType](../../../Part5/DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;registerNodesCount|[ServiceCounterDataType](../../../Part5/DataTypes/ServiceCounterDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;unregisterNodesCount|[ServiceCounterDataType](../../../Part5/DataTypes/ServiceCounterDataType/readme.md)||

The representation of the SessionDiagnosticsDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|SessionDiagnosticsDataType|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

