<!-- datatype -->
## AccessLevelType
  
<!-- end of description -->
The fields of the AccessLevelType DataType are defined in the following table:  

|Name|Bit No.| Description|
|---|---|---|
|CurrentRead|0||
|CurrentWrite|1||
|HistoryRead|2||
|HistoryWrite|3||
|SemanticChange|4||
|StatusWrite|5||
|TimestampWrite|6||

The representation of the AccessLevelType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15031|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|AccessLevelType|
|IsAbstract|False|
|BaseType|[Byte](../../DataTypes/Byte/readme.md)|
|Categories||

The references from the AccessLevelType DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|OptionSetValues|[LocalizedText](../../DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

