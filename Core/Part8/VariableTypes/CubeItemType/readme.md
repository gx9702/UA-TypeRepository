<!-- objecttype -->
## CubeItemType
CubeItemType represents a cube of values like a spatial particle distribution, where the particle position is given by X which is the column, Y the row and Z the depth. In the example of a spatial partical distribution, the value is the particle size. CubeItemType is formally defined in Table 12.  
<!-- end of text -->
The representation of the CubeItemType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=12057|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|CubeItemType|
|NodeClass|VariableType|
|DataType|[BaseDataType](../../../Part3/DataTypes/BaseDataType/readme.md)|
|ValueRank|3|
|IsAbstract|False|
|BaseType|[ArrayItemType](../../../Part8/VariableTypes/ArrayItemType/readme.md)|
|Categories|Part8|

The references from the CubeItemType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[XAxisDefinition](#XAxisDefinition)|[AxisInformation](../../../Part8/DataTypes/AxisInformation/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[YAxisDefinition](#YAxisDefinition)|[AxisInformation](../../../Part8/DataTypes/AxisInformation/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ZAxisDefinition](#ZAxisDefinition)|[AxisInformation](../../../Part8/DataTypes/AxisInformation/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


