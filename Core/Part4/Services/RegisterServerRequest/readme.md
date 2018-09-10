<!-- datatype -->
## RegisterServerRequest
Registers a server with the discovery server.  
<!-- end of description -->
The fields of the RegisterServerRequest DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|RegisterServerRequest|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;requestHeader|[RequestHeader](../../../Part4/Services/RequestHeader/readme.md)|A standard header included in all requests sent to a server.|
|&nbsp;&nbsp;&nbsp;&nbsp;server|[RegisteredServer](../../../Part4/DataTypes/RegisteredServer/readme.md)|The server to register.|

The representation of the RegisterServerRequest DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|RegisterServerRequest|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

