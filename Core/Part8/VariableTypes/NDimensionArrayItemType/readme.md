<!-- objecttype -->
## NDimensionArrayItemType
This VariableType defines a generic multi-dimensional ArrayItem.
This approach minimizes the number of types however it may be proved more difficult to utilize for control system interactions.
NDimensionArrayItemType is formally defined in Table 13.  
The representation of the NDimensionArrayItemType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|NDimensionArrayItemType|
|NodeClass|VariableType|
|IsAbtract|False|
|BaseType|[ArrayItemType](../../../Part8/VariableTypes/ArrayItemType/readme.md)|

The references from the NDimensionArrayItemType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[AxisDefinition](#AxisDefinition)|[AxisInformation](../../../Part8/DataTypes/AxisInformation/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


