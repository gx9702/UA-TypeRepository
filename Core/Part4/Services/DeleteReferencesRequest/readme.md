<!-- datatype -->
## DeleteReferencesRequest
Delete one or more references from the server address space.  
<!-- end of description -->
The fields of the DeleteReferencesRequest DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|DeleteReferencesRequest|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;requestHeader|[RequestHeader](../../../Part4/Services/RequestHeader/readme.md)|A standard header included in all requests sent to a server.|
|&nbsp;&nbsp;&nbsp;&nbsp;referencesToDelete|[DeleteReferencesItem](../../../Part4/DataTypes/DeleteReferencesItem/readme.md)[]|The list of references to delete.|

The representation of the DeleteReferencesRequest DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=504|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|DeleteReferencesRequest|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part4/Services|

