<!-- datatype -->
## FieldMetaData
<!-- end of description -->
The fields of the FieldMetaData DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|FieldMetaData|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;name|[String](../../../Part3/DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;description|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;fieldFlags|[DataSetFieldFlags](../../../Part14/DataTypes/DataSetFieldFlags/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;builtInType|[Byte](../../../Part3/DataTypes/Byte/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;dataType|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;valueRank|[Int32](../../../Part3/DataTypes/Int32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;arrayDimensions|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;maxStringLength|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;dataSetFieldId|[Guid](../../../Part3/DataTypes/Guid/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;properties|[KeyValuePair](../../../Part5/DataTypes/KeyValuePair/readme.md)[]||

The representation of the FieldMetaData DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|FieldMetaData|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

