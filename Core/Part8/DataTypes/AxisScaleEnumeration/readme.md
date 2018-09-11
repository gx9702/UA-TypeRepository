<!-- datatype -->
## AxisScaleEnumeration
This enumeration identifies on which type of axis the data shall be displayed. Its values are defined in Table 24.  
<!-- end of description -->
The fields of the AxisScaleEnumeration DataType are defined in the following table:  

|Name|Value| Description|
|---|---|---|
|Linear|0||
|Log|1||
|Ln|2||

The representation of the AxisScaleEnumeration DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=12077|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|AxisScaleEnumeration|
|IsAbstract|False|
|BaseType|[Enumeration](../../../Part3/DataTypes/Enumeration/readme.md)|
|Categories|Part8|

The references from the AxisScaleEnumeration DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|EnumStrings|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

