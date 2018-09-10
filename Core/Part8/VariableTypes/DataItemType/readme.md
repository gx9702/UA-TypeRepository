<!-- objecttype -->
## DataItemType
This VariableType defines the general characteristics of a DataItem. All other DataItem Types derive from it. The DataItemType derives from the BaseDataVariableType and therefore shares the variable model as described in Part 3 and Part 5. It is formally defined in Table 1.  
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
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[Definition](#Definition)|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ValuePrecision](#ValuePrecision)|[Double](../../../Part3/DataTypes/Double/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|VariableType|[AnalogItemType](#AnalogItemType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|VariableType|[EUItemType](#EUItemType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|VariableType|[AnalogUnitItemType](#AnalogUnitItemType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|VariableType|[DiscreteItemType](#DiscreteItemType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|VariableType|[ArrayItemType](#ArrayItemType)||||


