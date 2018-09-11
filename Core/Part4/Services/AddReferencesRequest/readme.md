<!-- datatype -->
## AddReferencesRequest
Adds one or more references to the server address space.  
<!-- end of description -->
The fields of the AddReferencesRequest DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|AddReferencesRequest|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;requestHeader|[RequestHeader](../../../Part4/Services/RequestHeader/readme.md)|A standard header included in all requests sent to a server.|
|&nbsp;&nbsp;&nbsp;&nbsp;referencesToAdd|[AddReferencesItem](../../../Part4/DataTypes/AddReferencesItem/readme.md)[]|The list of references to add.|

The representation of the AddReferencesRequest DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=492|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|AddReferencesRequest|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part4/Services|

