<!-- datatype -->
## PublishedVariableDataType
  
<!-- end of description -->
The fields of the PublishedVariableDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|PublishedVariableDataType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;publishedVariable|[NodeId](../../DataTypes/NodeId/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;attributeId|[IntegerId](../../DataTypes/IntegerId/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;samplingIntervalHint|[Duration](../../DataTypes/Duration/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;deadbandType|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;deadbandValue|[Double](../../DataTypes/Double/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;indexRange|[NumericRange](../../DataTypes/NumericRange/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;substituteValue|[BaseDataType](../../DataTypes/BaseDataType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;metaDataProperties|[QualifiedName](../../DataTypes/QualifiedName/readme.md)[]||

The representation of the PublishedVariableDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=14273|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|PublishedVariableDataType|
|IsAbstract|False|
|BaseType|[Structure](../../DataTypes/Structure/readme.md)|
|Categories||

