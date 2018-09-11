<!-- objecttype -->
## XYArrayItemType
XYArrayItemType represents a vector of XVType values like a list of peaks, where XVType.x is the position of the peak and XVType.value is its intensity. XYArrayItemType is formally defined in Table 10.  
<!-- end of text -->
The representation of the XYArrayItemType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=12038|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|XYArrayItemType|
|NodeClass|VariableType|
|DataType|[XVType](../../../Part8/DataTypes/XVType/readme.md)|
|ValueRank|1|
|IsAbstract|False|
|BaseType|[ArrayItemType](../../../Part8/VariableTypes/ArrayItemType/readme.md)|
|Categories|Part8|

The references from the XYArrayItemType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[XAxisDefinition](#XAxisDefinition)|[AxisInformation](../../../Part8/DataTypes/AxisInformation/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


