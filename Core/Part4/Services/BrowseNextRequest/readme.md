<!-- datatype -->
## BrowseNextRequest
Continues one or more browse operations.  
<!-- end of description -->
The fields of the BrowseNextRequest DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|BrowseNextRequest|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;requestHeader|[RequestHeader](../../../Part4/Services/RequestHeader/readme.md)|A standard header included in all requests sent to a server.|
|&nbsp;&nbsp;&nbsp;&nbsp;releaseContinuationPoints|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)|If TRUE the continuation points are released and no results are returned.|
|&nbsp;&nbsp;&nbsp;&nbsp;continuationPoints|[ContinuationPoint](../../../Part4/DataTypes/ContinuationPoint/readme.md)[]|The contination points returned from a previous call to Browse and BrowseNext.|

The representation of the BrowseNextRequest DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|BrowseNextRequest|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

