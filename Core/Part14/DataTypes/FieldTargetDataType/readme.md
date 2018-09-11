<!-- datatype -->
## FieldTargetDataType
This DataType is used to provide the metadata for the relation between a field in a DataSetMessage and a target Variable in a DataSetReader. The FieldTargetDataType is formally defined in Table 44.  
<!-- end of description -->
The fields of the FieldTargetDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|FieldTargetDataType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;dataSetFieldId|[Guid](../../../Part3/DataTypes/Guid/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;receiverIndexRange|[NumericRange](../../../Part4/DataTypes/NumericRange/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;targetNodeId|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;attributeId|[IntegerId](../../../Part4/DataTypes/IntegerId/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;writeIndexRange|[NumericRange](../../../Part4/DataTypes/NumericRange/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;overrideValueHandling|[OverrideValueHandling](../../../Part14/DataTypes/OverrideValueHandling/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;overrideValue|[BaseDataType](../../../Part3/DataTypes/BaseDataType/readme.md)||

The representation of the FieldTargetDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=14744|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|FieldTargetDataType|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part14|

