<!-- objecttype -->
## MVAModelType
Hold the descriptions of a mathematical process and associated information to convert scaled data into one or more process values.  
<!-- end of text -->
The representation of the MVAModelType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|ns=1;i=2009|
|NamespaceUri|http://opcfoundation.org/UA/ADI/|
|BrowseName|MVAModelType|
|NodeClass|VariableType|
|DataType|[ByteString](../../../Core/Part3/DataTypes/ByteString/readme.md)|
|ValueRank|-2|
|IsAbstract|False|
|BaseType|[ChemometricModelType](../../VariableTypes/ChemometricModelType/readme.md)|
|Categories||

The references from the MVAModelType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasOutput](../../ReferenceTypes/HasOutput/readme.md)|Variable|[&lt;User defined Output#&gt;](#&lt;User defined Output#&gt;)|[BaseDataType](../../../Core/Part3/DataTypes/BaseDataType/readme.md)|[MVAOutputParameterType](../../VariableTypes/MVAOutputParameterType/readme.md)|[OptionalPlaceholder](../../../Core/Objects/OptionalPlaceholder/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[MainDataIndex](#MainDataIndex)|[Int32](../../../Core/Part3/DataTypes/Int32/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|


