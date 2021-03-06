<!-- datatype -->
## StructureField
  
<!-- end of description -->
The fields of the StructureField DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|StructureField|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;name|[String](../../DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;description|[LocalizedText](../../DataTypes/LocalizedText/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;dataType|[NodeId](../../DataTypes/NodeId/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;valueRank|[Int32](../../DataTypes/Int32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;arrayDimensions|[UInt32](../../DataTypes/UInt32/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;maxStringLength|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;isOptional|[Boolean](../../DataTypes/Boolean/readme.md)||

The representation of the StructureField DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=101|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|StructureField|
|IsAbstract|False|
|BaseType|[Structure](../../DataTypes/Structure/readme.md)|
|Categories||

