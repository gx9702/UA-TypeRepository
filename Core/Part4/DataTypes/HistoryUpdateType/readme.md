<!-- datatype -->
## HistoryUpdateType
  
<!-- end of description -->
The fields of the HistoryUpdateType DataType are defined in the following table:  

|Name|Value| Description|
|---|---|---|
|Insert|1||
|Replace|2||
|Update|3||
|Delete|4||

The representation of the HistoryUpdateType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=11234|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|HistoryUpdateType|
|IsAbstract|False|
|BaseType|[Enumeration](../../../Part3/DataTypes/Enumeration/readme.md)|
|Categories|Part4|

The references from the HistoryUpdateType DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|EnumValues|[EnumValueType](../../../Part3/DataTypes/EnumValueType/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

