<!-- objecttype -->
## DataItemType
The representation of the DataItemType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|DataItemType|
|NodeClass|VariableType|
|IsAbtract|False|
|BaseType|[BaseDataVariableType](../../../Part5/VariableTypes/BaseDataVariableType/readme.md)|

The references from the DataItemType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|Definition||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|ValuePrecision||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|VariableType|AnalogItemType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|VariableType|EUItemType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|VariableType|AnalogUnitItemType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|VariableType|DiscreteItemType|[BaseDataType](../../../Part3/DataTypes/BaseDataType/readme.md)[]|||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|VariableType|ArrayItemType|[BaseDataType](../../../Part3/DataTypes/BaseDataType/readme.md)[]|||

