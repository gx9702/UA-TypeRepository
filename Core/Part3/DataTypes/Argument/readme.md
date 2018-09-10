<!-- datatype -->
## Argument
An argument for a method.  
<!-- end of description -->
The fields of the Argument DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|Argument|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;name|[String](../../../Part3/DataTypes/String/readme.md)|The name of the argument.|
|&nbsp;&nbsp;&nbsp;&nbsp;dataType|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)|The data type of the argument.|
|&nbsp;&nbsp;&nbsp;&nbsp;valueRank|[Int32](../../../Part3/DataTypes/Int32/readme.md)|Whether the argument is an array type and the rank of the array if it is.|
|&nbsp;&nbsp;&nbsp;&nbsp;arrayDimensions|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)[]|The number of dimensions if the argument is an array type and one or more dimensions have a fixed length.|
|&nbsp;&nbsp;&nbsp;&nbsp;description|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)|The description for the argument.|

The representation of the Argument DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|Argument|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
