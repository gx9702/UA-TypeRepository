<!-- objecttype -->
## DataSetWriterType
The representation of the DataSetWriterType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|DataSetWriterType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[BaseObjectType](../../../Part5/ObjectTypes/BaseObjectType/readme.md)|

The references from the DataSetWriterType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|DataSetWriterId||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|DataSetFieldContentMask||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|KeyFrameCount||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|DataSetWriterProperties||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|TransportSettings||[DataSetWriterTransportType](../../Part14/ObjectTypes/DataSetWriterTransportType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|MessageSettings||[DataSetWriterMessageType](../../Part14/ObjectTypes/DataSetWriterMessageType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|Status||[PubSubStatusType](../../Part14/ObjectTypes/PubSubStatusType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|Diagnostics||[PubSubDiagnosticsDataSetWriterType](../../Part14/ObjectTypes/PubSubDiagnosticsDataSetWriterType/readme.md)|[Optional](../../Objects/Optional/readme.md)|

