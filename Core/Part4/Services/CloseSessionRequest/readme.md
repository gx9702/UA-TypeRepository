<!-- datatype -->
## CloseSessionRequest
Closes a session with the server.  
<!-- end of description -->
The fields of the CloseSessionRequest DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|CloseSessionRequest|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;requestHeader|[RequestHeader](../../../Part4/Services/RequestHeader/readme.md)|A standard header included in all requests sent to a server.|
|&nbsp;&nbsp;&nbsp;&nbsp;deleteSubscriptions|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)|If TRUE all subscriptions are deleted when the session is closed.|

The representation of the CloseSessionRequest DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=471|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|CloseSessionRequest|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part4/Services|

