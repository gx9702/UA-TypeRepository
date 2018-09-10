<!-- objecttype -->
## XYArrayItemType
XYArrayItemType represents a vector of XVType values like a list of peaks, where XVType.x is the position of the peak and XVType.value is its intensity. XYArrayItemType is formally defined in Table 10.  
The representation of the XYArrayItemType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|XYArrayItemType|
|NodeClass|VariableType|
|IsAbtract|False|
|BaseType|[ArrayItemType](../../../Part8/VariableTypes/ArrayItemType/readme.md)|

The references from the XYArrayItemType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[XAxisDefinition](#XAxisDefinition)|[AxisInformation](../../../Part8/DataTypes/AxisInformation/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

