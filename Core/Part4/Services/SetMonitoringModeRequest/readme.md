<!-- datatype -->
## SetMonitoringModeRequest
<!-- end of description -->
The fields of the SetMonitoringModeRequest DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|SetMonitoringModeRequest|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;requestHeader|[RequestHeader](../../../Part4/Services/RequestHeader/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;subscriptionId|[IntegerId](../../../Part4/DataTypes/IntegerId/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;monitoringMode|[MonitoringMode](../../../Part4/Services/MonitoringMode/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;monitoredItemIds|[IntegerId](../../../Part4/DataTypes/IntegerId/readme.md)[]||

The representation of the SetMonitoringModeRequest DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|SetMonitoringModeRequest|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

