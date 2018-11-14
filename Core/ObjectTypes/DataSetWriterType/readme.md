<!-- objecttype -->
## DataSetWriterType
  
<!-- end of text -->
The representation of the DataSetWriterType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15298|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|DataSetWriterType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[BaseObjectType](../../ObjectTypes/BaseObjectType/readme.md)|
|Categories||

The references from the DataSetWriterType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[DataSetWriterId](#DataSetWriterId)|[UInt16](../../DataTypes/UInt16/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[DataSetFieldContentMask](#DataSetFieldContentMask)|[DataSetFieldContentMask](../../DataTypes/DataSetFieldContentMask/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[KeyFrameCount](#KeyFrameCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[DataSetWriterProperties](#DataSetWriterProperties)|[KeyValuePair](../../DataTypes/KeyValuePair/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[TransportSettings](#TransportSettings)||[DataSetWriterTransportType](../../ObjectTypes/DataSetWriterTransportType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[MessageSettings](#MessageSettings)||[DataSetWriterMessageType](../../ObjectTypes/DataSetWriterMessageType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[Status](#Status)||[PubSubStatusType](../../ObjectTypes/PubSubStatusType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[Diagnostics](#Diagnostics)||[PubSubDiagnosticsDataSetWriterType](../../ObjectTypes/PubSubDiagnosticsDataSetWriterType/readme.md)|[Optional](../../Objects/Optional/readme.md)|


