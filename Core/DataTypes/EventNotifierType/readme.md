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
|NodeId|i=15033|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|EventNotifierType|
|IsAbstract|False|
|BaseType|[Byte](../../DataTypes/Byte/readme.md)|
|Categories||

The references from the EventNotifierType DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|OptionSetValues|[LocalizedText](../../DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

