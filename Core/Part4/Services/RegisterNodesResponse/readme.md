<!-- datatype -->
## RegisterNodesResponse
Registers one or more nodes for repeated use within a session.  
<!-- end of description -->
The fields of the RegisterNodesResponse DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|RegisterNodesResponse|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;responseHeader|[ResponseHeader](../../../Part4/Services/ResponseHeader/readme.md)|A standard header included in all responses returned by servers.|
|&nbsp;&nbsp;&nbsp;&nbsp;registeredNodeIds|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)[]|The list of node ids that can be used for fast access to the nodes.|

The representation of the RegisterNodesResponse DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|RegisterNodesResponse|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

