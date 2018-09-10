<!-- datatype -->
## GetEndpointsRequest
<!-- end of description -->
The fields of the GetEndpointsRequest DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|GetEndpointsRequest|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;requestHeader|[RequestHeader](../../../Part4/Services/RequestHeader/readme.md)|A standard header included in all requests sent to a server.|
|&nbsp;&nbsp;&nbsp;&nbsp;endpointUrl|[String](../../../Part3/DataTypes/String/readme.md)|The URL used by the client to send the request.|
|&nbsp;&nbsp;&nbsp;&nbsp;localeIds|[LocaleId](../../../Part3/DataTypes/LocaleId/readme.md)[]|The locales to use when constructing a response.|
|&nbsp;&nbsp;&nbsp;&nbsp;profileUris|[String](../../../Part3/DataTypes/String/readme.md)[]|The URIs of the transport profiles for the endpoints to return (all endpoints returned if none specified).|

The representation of the GetEndpointsRequest DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|GetEndpointsRequest|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

