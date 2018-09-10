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
|BrowseName|AccessLevelExType|
|IsAbtract|False|
|BaseType|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)|

The references from the AccessLevelExType DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|OptionSetValues||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

