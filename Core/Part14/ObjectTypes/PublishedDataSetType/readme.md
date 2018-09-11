<!-- objecttype -->
## PublishedDataSetType
This ObjectType is the base type for PublishedDataSets. It defines the metadata and the configuration version of the DataSets sent as DataSetMessages through DataSetWriters.

The PublishedDataSetType is the base type for configurable DataSets. Derived types like PublishedDataItemsType and PublishedEventsType defines how to collect the DataSet to be published. For PublishedDataItemsType this is a list of monitored Variables. For PublishedEventsType this is an Event selection. The list of monitored Variables or the list of selected EventFields defines the content and metadata of the PublishedDataSetType Object.

If the content of the DataSet is defined by a product specific configuration and the source of the DataSet is not known, the PublishedDataSetType can be used directly to expose the PublishedDataSet in the AddressSpace of the Publisher.

The PublishedDataSetType is formally defined in Table 105.  
<!-- end of text -->
The representation of the PublishedDataSetType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=14509|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|PublishedDataSetType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[BaseObjectType](../../../Part5/ObjectTypes/BaseObjectType/readme.md)|
|Categories|Part14|

The references from the PublishedDataSetType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[DataSetToWriter](../../../Part14/ReferenceTypes/DataSetToWriter/readme.md)|Object|[&lt;DataSetWriterName&gt;](#&lt;DataSetWriterName&gt;)||[DataSetWriterType](../../Part14/ObjectTypes/DataSetWriterType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ConfigurationVersion](#ConfigurationVersion)|[ConfigurationVersionDataType](../../../Part14/DataTypes/ConfigurationVersionDataType/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[DataSetMetaData](#DataSetMetaData)|[DataSetMetaDataType](../../../Part14/DataTypes/DataSetMetaDataType/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[DataSetClassId](#DataSetClassId)|[Guid](../../../Part3/DataTypes/Guid/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[ExtensionFields](#ExtensionFields)||[ExtensionFieldsType](../../Part14/ObjectTypes/ExtensionFieldsType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[PublishedDataItemsType](#PublishedDataItemsType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[PublishedEventsType](#PublishedEventsType)||||


