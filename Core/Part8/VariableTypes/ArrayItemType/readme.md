<!-- objecttype -->
## ArrayItemType
The representation of the ArrayItemType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|ArrayItemType|
|NodeClass|VariableType|
|IsAbtract|True|
|BaseType|[DataItemType](../../../Part8/VariableTypes/DataItemType/readme.md)|

The references from the ArrayItemType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|InstrumentRange||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|EURange||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|EngineeringUnits||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|Title||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|AxisScaleType||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|VariableType|YArrayItemType|[BaseDataType](../../../Part3/DataTypes/BaseDataType/readme.md)[]|||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|VariableType|XYArrayItemType|[XVType](../../../Part8/DataTypes/XVType/readme.md)[]|||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|VariableType|ImageItemType|[BaseDataType](../../../Part3/DataTypes/BaseDataType/readme.md)[]|||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|VariableType|CubeItemType|[BaseDataType](../../../Part3/DataTypes/BaseDataType/readme.md)[]|||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|VariableType|NDimensionArrayItemType|[BaseDataType](../../../Part3/DataTypes/BaseDataType/readme.md)[]|||

