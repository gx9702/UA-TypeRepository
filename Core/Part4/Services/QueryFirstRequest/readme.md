<!-- datatype -->
## QueryFirstRequest
  
<!-- end of description -->
The fields of the QueryFirstRequest DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|QueryFirstRequest|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;requestHeader|[RequestHeader](../../../Part4/Services/RequestHeader/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;view|[ViewDescription](../../../Part4/Services/ViewDescription/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;nodeTypes|[NodeTypeDescription](../../../Part4/Services/NodeTypeDescription/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;filter|[ContentFilter](../../../Part4/DataTypes/ContentFilter/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;maxDataSetsToReturn|[Counter](../../../Part4/DataTypes/Counter/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;maxReferencesToReturn|[Counter](../../../Part4/DataTypes/Counter/readme.md)||

The representation of the QueryFirstRequest DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=613|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|QueryFirstRequest|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part4/Services|

