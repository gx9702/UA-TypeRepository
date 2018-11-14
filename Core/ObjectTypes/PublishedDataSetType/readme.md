<!-- objecttype -->
## PublishedDataSetType
  
<!-- end of text -->
The representation of the PublishedDataSetType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=14509|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|PublishedDataSetType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[BaseObjectType](../../ObjectTypes/BaseObjectType/readme.md)|
|Categories||

The references from the PublishedDataSetType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[DataSetToWriter](../../ReferenceTypes/DataSetToWriter/readme.md)|Object|[&lt;DataSetWriterName&gt;](#&lt;DataSetWriterName&gt;)||[DataSetWriterType](../../ObjectTypes/DataSetWriterType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ConfigurationVersion](#ConfigurationVersion)|[ConfigurationVersionDataType](../../DataTypes/ConfigurationVersionDataType/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[DataSetMetaData](#DataSetMetaData)|[DataSetMetaDataType](../../DataTypes/DataSetMetaDataType/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[DataSetClassId](#DataSetClassId)|[Guid](../../DataTypes/Guid/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[ExtensionFields](#ExtensionFields)||[ExtensionFieldsType](../../ObjectTypes/ExtensionFieldsType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[PublishedDataItemsType](#PublishedDataItemsType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[PublishedEventsType](#PublishedEventsType)||||


