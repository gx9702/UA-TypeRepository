<!-- datatype -->
## PublishedVariableDataType
<!-- end of description -->
The fields of the PublishedVariableDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|PublishedVariableDataType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;publishedVariable|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;attributeId|[IntegerId](../../../Part4/DataTypes/IntegerId/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;samplingIntervalHint|[Duration](../../../Part3/DataTypes/Duration/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;deadbandType|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;deadbandValue|[Double](../../../Part3/DataTypes/Double/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;indexRange|[NumericRange](../../../Part4/DataTypes/NumericRange/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;substituteValue|[BaseDataType](../../../Part3/DataTypes/BaseDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;metaDataProperties|[QualifiedName](../../../Part3/DataTypes/QualifiedName/readme.md)[]||

The representation of the PublishedVariableDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|PublishedVariableDataType|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

