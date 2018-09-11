<!-- datatype -->
## BrowsePath
A request to translate a path into a node id.  
<!-- end of description -->
The fields of the BrowsePath DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|BrowsePath|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;startingNode|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)|The starting point for the search.|
|&nbsp;&nbsp;&nbsp;&nbsp;relativePath|[RelativePath](../../../Part4/DataTypes/RelativePath/readme.md)|The path to follow.|

The representation of the BrowsePath DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=543|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|BrowsePath|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part4/Services|

