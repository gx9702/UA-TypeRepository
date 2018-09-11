<!-- datatype -->
## ViewAttributes
The attributes for a view node.  
<!-- end of description -->
The fields of the ViewAttributes DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|ViewAttributes|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;containsNoLoops|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)|If TRUE the view contains a tree of non-looping hierarchical references.|
|&nbsp;&nbsp;&nbsp;&nbsp;eventNotifier|[Byte](../../../Part3/DataTypes/Byte/readme.md)|A mask indicating whether events are produced by the view.|

The representation of the ViewAttributes DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=373|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|ViewAttributes|
|IsAbstract|False|
|BaseType|[NodeAttributes](../../../Part4/Services/NodeAttributes/readme.md)|
|Categories|Part4/Services|

