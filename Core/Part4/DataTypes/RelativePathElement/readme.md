<!-- datatype -->
## RelativePathElement
<!-- end of description -->
The fields of the RelativePathElement DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|RelativePathElement|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;referenceTypeId|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)|The type of reference to follow.|
|&nbsp;&nbsp;&nbsp;&nbsp;isInverse|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)|If TRUE the reverse reference is followed.|
|&nbsp;&nbsp;&nbsp;&nbsp;includeSubtypes|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)|If TRUE then subtypes of the reference type are followed.|
|&nbsp;&nbsp;&nbsp;&nbsp;targetName|[QualifiedName](../../../Part3/DataTypes/QualifiedName/readme.md)|The browse name of the target.|

The representation of the RelativePathElement DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|RelativePathElement|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

