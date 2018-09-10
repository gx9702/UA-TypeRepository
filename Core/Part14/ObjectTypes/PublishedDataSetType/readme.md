<!-- objecttype -->
## PublishedDataSetType
The representation of the PublishedDataSetType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|PublishedDataSetType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[BaseObjectType](../../../Part5/ObjectTypes/BaseObjectType/readme.md)|

The references from the PublishedDataSetType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[DataSetToWriter](../../../Part14/ReferenceTypes/DataSetToWriter/readme.md)|Object|&lt;DataSetWriterName&gt;||[DataSetWriterType](../../Part14/ObjectTypes/DataSetWriterType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|ConfigurationVersion||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|DataSetMetaData||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|DataSetClassId||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|ExtensionFields||[ExtensionFieldsType](../../Part14/ObjectTypes/ExtensionFieldsType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|PublishedDataItemsType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|PublishedEventsType||||

