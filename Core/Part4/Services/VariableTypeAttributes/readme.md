<!-- datatype -->
## VariableTypeAttributes
The attributes for a variable type node.  
<!-- end of description -->
The fields of the VariableTypeAttributes DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|VariableTypeAttributes|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;value|[BaseDataType](../../../Part3/DataTypes/BaseDataType/readme.md)|The default value when creating new instances.|
|&nbsp;&nbsp;&nbsp;&nbsp;dataType|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)|The data type of the value.|
|&nbsp;&nbsp;&nbsp;&nbsp;valueRank|[Int32](../../../Part3/DataTypes/Int32/readme.md)|Whether the value is an array type and the rank of the array if it is.|
|&nbsp;&nbsp;&nbsp;&nbsp;arrayDimensions|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)[]|The number of dimensions if the value is an array type and one or more dimensions have a fixed length.|
|&nbsp;&nbsp;&nbsp;&nbsp;isAbstract|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)|If TRUE the type is abstract and only subtypes of it appear in the address space.|

The representation of the VariableTypeAttributes DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|VariableTypeAttributes|
|IsAbtract|False|
|BaseType|[NodeAttributes](../../../Part4/Services/NodeAttributes/readme.md)|

