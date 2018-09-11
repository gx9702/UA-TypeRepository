<!-- datatype -->
## ViewDescription
The view to browse.  
<!-- end of description -->
The fields of the ViewDescription DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|ViewDescription|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;viewId|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)|The node id of the view.|
|&nbsp;&nbsp;&nbsp;&nbsp;timestamp|[UtcTime](../../../Part3/DataTypes/UtcTime/readme.md)|Browses the view at or before this time.|
|&nbsp;&nbsp;&nbsp;&nbsp;viewVersion|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)|Browses a specific version of the view .|

The representation of the ViewDescription DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=511|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|ViewDescription|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part4/Services|

