<!-- datatype -->
## FindServersRequest
Finds the servers known to the discovery server.  
<!-- end of description -->
The fields of the FindServersRequest DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|FindServersRequest|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;requestHeader|[RequestHeader](../../../Part4/Services/RequestHeader/readme.md)|A standard header included in all requests sent to a server.|
|&nbsp;&nbsp;&nbsp;&nbsp;endpointUrl|[String](../../../Part3/DataTypes/String/readme.md)|The URL used by the client to send the request.|
|&nbsp;&nbsp;&nbsp;&nbsp;localeIds|[LocaleId](../../../Part3/DataTypes/LocaleId/readme.md)[]|The locales to use when constructing a response.|
|&nbsp;&nbsp;&nbsp;&nbsp;serverUris|[String](../../../Part3/DataTypes/String/readme.md)[]|The URIs of the servers to return (all servers returned if none specified).|

The representation of the FindServersRequest DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|FindServersRequest|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

