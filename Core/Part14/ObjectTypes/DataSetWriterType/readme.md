<!-- objecttype -->
## DataSetWriterType
An instance of this ObjectType represents the configuration for a DataSetWriter. The DataSetWriterType is formally defined Table 123.  
<!-- end of text -->
The representation of the DataSetWriterType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15298|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|DataSetWriterType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[BaseObjectType](../../../Part5/ObjectTypes/BaseObjectType/readme.md)|
|Categories|Part14|

The references from the DataSetWriterType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[DataSetWriterId](#DataSetWriterId)|[UInt16](../../../Part3/DataTypes/UInt16/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[DataSetFieldContentMask](#DataSetFieldContentMask)|[DataSetFieldContentMask](../../../Part14/DataTypes/DataSetFieldContentMask/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[KeyFrameCount](#KeyFrameCount)|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[DataSetWriterProperties](#DataSetWriterProperties)|[KeyValuePair](../../../Part5/DataTypes/KeyValuePair/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[TransportSettings](#TransportSettings)||[DataSetWriterTransportType](../../Part14/ObjectTypes/DataSetWriterTransportType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[MessageSettings](#MessageSettings)||[DataSetWriterMessageType](../../Part14/ObjectTypes/DataSetWriterMessageType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Status](#Status)||[PubSubStatusType](../../Part14/ObjectTypes/PubSubStatusType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Diagnostics](#Diagnostics)||[PubSubDiagnosticsDataSetWriterType](../../Part14/ObjectTypes/PubSubDiagnosticsDataSetWriterType/readme.md)|[Optional](../../Objects/Optional/readme.md)|


