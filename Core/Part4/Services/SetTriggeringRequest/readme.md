<!-- datatype -->
## SetTriggeringRequest
<!-- end of description -->
The fields of the SetTriggeringRequest DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|SetTriggeringRequest|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;requestHeader|[RequestHeader](../../../Part4/Services/RequestHeader/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;subscriptionId|[IntegerId](../../../Part4/DataTypes/IntegerId/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;triggeringItemId|[IntegerId](../../../Part4/DataTypes/IntegerId/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;linksToAdd|[IntegerId](../../../Part4/DataTypes/IntegerId/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;linksToRemove|[IntegerId](../../../Part4/DataTypes/IntegerId/readme.md)[]||

The representation of the SetTriggeringRequest DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|SetTriggeringRequest|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

