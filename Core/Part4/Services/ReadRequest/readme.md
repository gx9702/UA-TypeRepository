<!-- datatype -->
## ReadRequest
  
<!-- end of description -->
The fields of the ReadRequest DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|ReadRequest|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;requestHeader|[RequestHeader](../../../Part4/Services/RequestHeader/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;maxAge|[Duration](../../../Part3/DataTypes/Duration/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;timestampsToReturn|[TimestampsToReturn](../../../Part4/Services/TimestampsToReturn/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;nodesToRead|[ReadValueId](../../../Part4/Services/ReadValueId/readme.md)[]||

The representation of the ReadRequest DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=629|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|ReadRequest|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part4/Services|

