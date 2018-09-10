<!-- objecttype -->
## ImageItemType
ImageItemType defines the general characteristics of an ImageItem which represents a matrix of values like an image, where the pixel position is given by X which is the column and Y the row. The value is the pixel intensity.
ImageItemType is formally defined in Table 11.  
The representation of the ImageItemType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|ImageItemType|
|NodeClass|VariableType|
|IsAbtract|False|
|BaseType|[ArrayItemType](../../../Part8/VariableTypes/ArrayItemType/readme.md)|

The references from the ImageItemType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[XAxisDefinition](#XAxisDefinition)|[AxisInformation](../../../Part8/DataTypes/AxisInformation/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[YAxisDefinition](#YAxisDefinition)|[AxisInformation](../../../Part8/DataTypes/AxisInformation/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


