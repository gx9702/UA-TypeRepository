<!-- datatype -->
## ModifyMonitoredItemsRequest
  
<!-- end of description -->
The fields of the ModifyMonitoredItemsRequest DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|ModifyMonitoredItemsRequest|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;requestHeader|[RequestHeader](../../../Part4/Services/RequestHeader/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;subscriptionId|[IntegerId](../../../Part4/DataTypes/IntegerId/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;timestampsToReturn|[TimestampsToReturn](../../../Part4/Services/TimestampsToReturn/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;itemsToModify|[MonitoredItemModifyRequest](../../../Part4/Services/MonitoredItemModifyRequest/readme.md)[]||

The representation of the ModifyMonitoredItemsRequest DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=761|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|ModifyMonitoredItemsRequest|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part4/Services|

