<!-- datatype -->
## BrowsePathTarget
<!-- end of description -->
The fields of the BrowsePathTarget DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|BrowsePathTarget|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;targetId|[ExpandedNodeId](../../../Part4/DataTypes/ExpandedNodeId/readme.md)|The id of the target node.|
|&nbsp;&nbsp;&nbsp;&nbsp;remainingPathIndex|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)|The index of the target in the relative path. UInt32.MaxValue if the entire path was processed.|

The representation of the BrowsePathTarget DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|BrowsePathTarget|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

