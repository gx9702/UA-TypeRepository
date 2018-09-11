<!-- datatype -->
## ViewNode
  
<!-- end of description -->
The fields of the ViewNode DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|ViewNode|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;containsNoLoops|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)|If TRUE the view contains a tree of non-looping hierarchical references.|
|&nbsp;&nbsp;&nbsp;&nbsp;eventNotifier|[Byte](../../../Part3/DataTypes/Byte/readme.md)|A mask indicating whether events are produced by the view.|

The representation of the ViewNode DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=279|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|ViewNode|
|IsAbstract|False|
|BaseType|[InstanceNode](../../../Part3/Services/InstanceNode/readme.md)|
|Categories|Part3/Services|

