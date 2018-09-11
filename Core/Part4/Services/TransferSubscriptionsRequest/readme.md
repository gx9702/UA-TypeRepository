<!-- datatype -->
## TransferSubscriptionsRequest
  
<!-- end of description -->
The fields of the TransferSubscriptionsRequest DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|TransferSubscriptionsRequest|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;requestHeader|[RequestHeader](../../../Part4/Services/RequestHeader/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;subscriptionIds|[IntegerId](../../../Part4/DataTypes/IntegerId/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;sendInitialValues|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)||

The representation of the TransferSubscriptionsRequest DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=839|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|TransferSubscriptionsRequest|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part4/Services|

