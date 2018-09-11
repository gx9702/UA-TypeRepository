<!-- datatype -->
## VariableAttributes
The attributes for a variable node.  
<!-- end of description -->
The fields of the VariableAttributes DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|VariableAttributes|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;value|[BaseDataType](../../../Part3/DataTypes/BaseDataType/readme.md)|The value of the variable.|
|&nbsp;&nbsp;&nbsp;&nbsp;dataType|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)|The data type of the value.|
|&nbsp;&nbsp;&nbsp;&nbsp;valueRank|[Int32](../../../Part3/DataTypes/Int32/readme.md)|Whether the value is an array type and the rank of the array if it is.|
|&nbsp;&nbsp;&nbsp;&nbsp;arrayDimensions|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)[]|The number of dimensions if the value is an array type and one or more dimensions have a fixed length.|
|&nbsp;&nbsp;&nbsp;&nbsp;accessLevel|[Byte](../../../Part3/DataTypes/Byte/readme.md)|A bit mask specifying how the value may be accessed.|
|&nbsp;&nbsp;&nbsp;&nbsp;userAccessLevel|[Byte](../../../Part3/DataTypes/Byte/readme.md)|A bit mask specifying how the value may be accessed by the current user.|
|&nbsp;&nbsp;&nbsp;&nbsp;minimumSamplingInterval|[Duration](../../../Part3/DataTypes/Duration/readme.md)|The minimum possible sampling interval for the value.|
|&nbsp;&nbsp;&nbsp;&nbsp;historizing|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)|TRUE if the server is current storing the history of the value.|

The representation of the VariableAttributes DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=355|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|VariableAttributes|
|IsAbstract|False|
|BaseType|[NodeAttributes](../../../Part4/Services/NodeAttributes/readme.md)|
|Categories|Part4/Services|

