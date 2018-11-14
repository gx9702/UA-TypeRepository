<!-- datatype -->
## FieldMetaData
  
<!-- end of description -->
The fields of the FieldMetaData DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|FieldMetaData|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;name|[String](../../DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;description|[LocalizedText](../../DataTypes/LocalizedText/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;fieldFlags|[DataSetFieldFlags](../../DataTypes/DataSetFieldFlags/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;builtInType|[Byte](../../DataTypes/Byte/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;dataType|[NodeId](../../DataTypes/NodeId/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;valueRank|[Int32](../../DataTypes/Int32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;arrayDimensions|[UInt32](../../DataTypes/UInt32/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;maxStringLength|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;dataSetFieldId|[Guid](../../DataTypes/Guid/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;properties|[KeyValuePair](../../DataTypes/KeyValuePair/readme.md)[]||

The representation of the FieldMetaData DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=14524|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|FieldMetaData|
|IsAbstract|False|
|BaseType|[Structure](../../DataTypes/Structure/readme.md)|
|Categories||

