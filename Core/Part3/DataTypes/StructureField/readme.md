<!-- datatype -->
## StructureField
<!-- end of description -->
The fields of the StructureField DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|StructureField|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;name|[String](../../../Part3/DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;description|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;dataType|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;valueRank|[Int32](../../../Part3/DataTypes/Int32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;arrayDimensions|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;maxStringLength|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;isOptional|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)||

The representation of the StructureField DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|StructureField|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

