<!-- datatype -->
## CreateSubscriptionRequest
<!-- end of description -->
The fields of the CreateSubscriptionRequest DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|CreateSubscriptionRequest|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;requestHeader|[RequestHeader](../../../Part4/Services/RequestHeader/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;requestedPublishingInterval|[Duration](../../../Part3/DataTypes/Duration/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;requestedLifetimeCount|[Counter](../../../Part4/DataTypes/Counter/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;requestedMaxKeepAliveCount|[Counter](../../../Part4/DataTypes/Counter/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;maxNotificationsPerPublish|[Counter](../../../Part4/DataTypes/Counter/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;publishingEnabled|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;priority|[Byte](../../../Part3/DataTypes/Byte/readme.md)||

The representation of the CreateSubscriptionRequest DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|CreateSubscriptionRequest|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

