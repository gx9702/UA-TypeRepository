<!-- datatype -->
## ExecutionDataType
  
<!-- end of description -->
The fields of the ExecutionDataType DataType are defined in the following table:  

|Name|Value| Description|
|---|---|---|
|ACTIVE|0||
|FEED_HOLD|1||
|INTERRUPTED|2||
|OPTIONAL_STOP|3||
|READY|4||
|PROGRAM_COMPLETED|5||
|PROGRAM_STOPPED|6||
|STOPPED|7||

The representation of the ExecutionDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|ns=1;i=2194|
|NamespaceUri|http://opcfoundation.org/UA/MTConnect/v2/|
|BrowseName|ExecutionDataType|
|IsAbstract|False|
|BaseType|[Enumeration](../../../Core/DataTypes/Enumeration/readme.md)|
|Categories||

The references from the ExecutionDataType DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Core/ReferenceTypes/HasProperty/readme.md)|Variable|EnumStrings|[LocalizedText](../../../Core/DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../../Core/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|

