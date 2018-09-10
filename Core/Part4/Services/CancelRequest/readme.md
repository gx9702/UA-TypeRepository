<!-- datatype -->
## CancelRequest
Cancels an outstanding request.  
<!-- end of description -->
The fields of the CancelRequest DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|CancelRequest|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;requestHeader|[RequestHeader](../../../Part4/Services/RequestHeader/readme.md)|A standard header included in all requests sent to a server.|
|&nbsp;&nbsp;&nbsp;&nbsp;requestHandle|[IntegerId](../../../Part4/DataTypes/IntegerId/readme.md)|The handle assigned by the client to the requests being cancelled.|

The representation of the CancelRequest DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|CancelRequest|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

