<!-- datatype -->
## HistoryReadRequest
  
<!-- end of description -->
The fields of the HistoryReadRequest DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|HistoryReadRequest|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;requestHeader|[RequestHeader](../../../Part4/Services/RequestHeader/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;historyReadDetails|[Structure](../../../Part3/DataTypes/Structure/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;timestampsToReturn|[TimestampsToReturn](../../../Part4/Services/TimestampsToReturn/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;releaseContinuationPoints|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;nodesToRead|[HistoryReadValueId](../../../Part4/Services/HistoryReadValueId/readme.md)[]||

The representation of the HistoryReadRequest DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=662|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|HistoryReadRequest|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part4/Services|

