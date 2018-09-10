<!-- objecttype -->
## MVAModelType
The representation of the MVAModelType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|MVAModelType|
|NodeClass|VariableType|
|IsAbtract|False|
|BaseType|[ChemometricModelType](../../VariableTypes/ChemometricModelType/readme.md)|

The references from the MVAModelType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasOutput](../../ReferenceTypes/HasOutput/readme.md)|Variable|&lt;User defined Output#&gt;|[BaseDataType](../../../Core/Part3/DataTypes/BaseDataType/readme.md)|[MVAOutputParameterType](../../VariableTypes/MVAOutputParameterType/readme.md)|[OptionalPlaceholder](../../../Core/Objects/OptionalPlaceholder/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|MainDataIndex|[Int32](../../../Core/Part3/DataTypes/Int32/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|

