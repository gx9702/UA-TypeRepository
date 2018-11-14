<!-- objecttype -->
## DataItemType
A variable that contains live automation data.  
<!-- end of text -->
The representation of the DataItemType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2365|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|DataItemType|
|NodeClass|VariableType|
|DataType|[BaseDataType](../../DataTypes/BaseDataType/readme.md)|
|ValueRank|-2|
|IsAbstract|False|
|BaseType|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|
|Categories||

The references from the DataItemType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[Definition](#Definition)|[String](../../DataTypes/String/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ValuePrecision](#ValuePrecision)|[Double](../../DataTypes/Double/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|VariableType|[BaseAnalogType](#BaseAnalogType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|VariableType|[DiscreteItemType](#DiscreteItemType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|VariableType|[ArrayItemType](#ArrayItemType)||||


