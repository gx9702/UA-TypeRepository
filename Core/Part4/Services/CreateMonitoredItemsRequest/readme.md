<!-- datatype -->
## CreateMonitoredItemsRequest
  
<!-- end of description -->
The fields of the CreateMonitoredItemsRequest DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|CreateMonitoredItemsRequest|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;requestHeader|[RequestHeader](../../../Part4/Services/RequestHeader/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;subscriptionId|[IntegerId](../../../Part4/DataTypes/IntegerId/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;timestampsToReturn|[TimestampsToReturn](../../../Part4/Services/TimestampsToReturn/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;itemsToCreate|[MonitoredItemCreateRequest](../../../Part4/Services/MonitoredItemCreateRequest/readme.md)[]||

The representation of the CreateMonitoredItemsRequest DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=749|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|CreateMonitoredItemsRequest|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part4/Services|

