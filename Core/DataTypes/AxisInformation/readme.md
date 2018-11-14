<!-- datatype -->
## AxisInformation
  
<!-- end of description -->
The fields of the AxisInformation DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|AxisInformation|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;engineeringUnits|[EUInformation](../../DataTypes/EUInformation/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;eURange|[Range](../../DataTypes/Range/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;title|[LocalizedText](../../DataTypes/LocalizedText/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;axisScaleType|[AxisScaleEnumeration](../../DataTypes/AxisScaleEnumeration/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;axisSteps|[Double](../../DataTypes/Double/readme.md)[]||

The representation of the AxisInformation DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=12079|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|AxisInformation|
|IsAbstract|False|
|BaseType|[Structure](../../DataTypes/Structure/readme.md)|
|Categories||

