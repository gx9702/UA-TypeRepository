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
|BrowseName|AccessLevelType|
|IsAbtract|False|
|BaseType|[Byte](../../../Part3/DataTypes/Byte/readme.md)|

The references from the AccessLevelType DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|OptionSetValues||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

