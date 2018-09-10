<!-- datatype -->
## SimpleAttributeOperand
<!-- end of description -->
The fields of the SimpleAttributeOperand DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|SimpleAttributeOperand|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;typeDefinitionId|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;browsePath|[QualifiedName](../../../Part3/DataTypes/QualifiedName/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;attributeId|[IntegerId](../../../Part4/DataTypes/IntegerId/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;indexRange|[NumericRange](../../../Part4/DataTypes/NumericRange/readme.md)||

The representation of the SimpleAttributeOperand DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|SimpleAttributeOperand|
|IsAbtract|False|
|BaseType|[FilterOperand](../../../Part4/DataTypes/FilterOperand/readme.md)|

