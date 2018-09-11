<!-- datatype -->
## RegisterNodesRequest
Registers one or more nodes for repeated use within a session.  
<!-- end of description -->
The fields of the RegisterNodesRequest DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|RegisterNodesRequest|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;requestHeader|[RequestHeader](../../../Part4/Services/RequestHeader/readme.md)|A standard header included in all requests sent to a server.|
|&nbsp;&nbsp;&nbsp;&nbsp;nodesToRegister|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)[]|The list of nodes to register.|

The representation of the RegisterNodesRequest DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=558|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|RegisterNodesRequest|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part4/Services|

