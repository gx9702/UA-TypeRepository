<!-- datatype -->
## AccessLevelExType
  
<!-- end of description -->
The fields of the AccessLevelExType DataType are defined in the following table:  

|Name|Bit No.| Description|
|---|---|---|
|CurrentRead|0||
|CurrentWrite|1||
|HistoryRead|2||
|HistoryWrite|3||
|SemanticChange|4||
|StatusWrite|5||
|TimestampWrite|6||
|NonatomicRead|8||
|NonatomicWrite|9||
|WriteFullArrayOnly|10||

The representation of the AccessLevelExType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15406|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|AccessLevelExType|
|IsAbstract|False|
|BaseType|[UInt32](../../DataTypes/UInt32/readme.md)|
|Categories||

The references from the AccessLevelExType DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|OptionSetValues|[LocalizedText](../../DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

