<!-- datatype -->
## EventNotifierType
<!-- end of description -->
The fields of the EventNotifierType DataType are defined in the following table:  

|Name|Bit No.| Description|
|---|---|---|
|SubscribeToEvents|0||
|HistoryRead|2||
|HistoryWrite|3||

The representation of the EventNotifierType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|EventNotifierType|
|IsAbtract|False|
|BaseType|[Byte](../../../Part3/DataTypes/Byte/readme.md)|

The references from the EventNotifierType DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|OptionSetValues|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

