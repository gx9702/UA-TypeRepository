<!-- datatype -->
## BrowseDescription
A request to browse the the references from a node.  
<!-- end of description -->
The fields of the BrowseDescription DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|BrowseDescription|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;nodeId|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)|The id of the node to browse.|
|&nbsp;&nbsp;&nbsp;&nbsp;browseDirection|[BrowseDirection](../../../Part4/Services/BrowseDirection/readme.md)|The direction of the references to return.|
|&nbsp;&nbsp;&nbsp;&nbsp;referenceTypeId|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)|The type of references to return.|
|&nbsp;&nbsp;&nbsp;&nbsp;includeSubtypes|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)|Includes subtypes of the reference type.|
|&nbsp;&nbsp;&nbsp;&nbsp;nodeClassMask|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)|A mask indicating which node classes to return. 0 means return all nodes.|
|&nbsp;&nbsp;&nbsp;&nbsp;resultMask|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)|A mask indicating which fields should be returned in the results.|

The representation of the BrowseDescription DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|BrowseDescription|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

