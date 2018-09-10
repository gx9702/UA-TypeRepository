<!-- objecttype -->
## WriterGroupType
  
The representation of the WriterGroupType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|WriterGroupType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[PubSubGroupType](../../../Part14/ObjectTypes/PubSubGroupType/readme.md)|

The references from the WriterGroupType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[WriterGroupId](#WriterGroupId)|[UInt16](../../../Part3/DataTypes/UInt16/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[PublishingInterval](#PublishingInterval)|[Duration](../../../Part3/DataTypes/Duration/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[KeepAliveTime](#KeepAliveTime)|[Duration](../../../Part3/DataTypes/Duration/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[Priority](#Priority)|[Byte](../../../Part3/DataTypes/Byte/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[LocaleIds](#LocaleIds)|[LocaleId](../../../Part3/DataTypes/LocaleId/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[TransportSettings](#TransportSettings)||[WriterGroupTransportType](../../Part14/ObjectTypes/WriterGroupTransportType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[MessageSettings](#MessageSettings)||[WriterGroupMessageType](../../Part14/ObjectTypes/WriterGroupMessageType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasDataSetWriter](../../../Part14/ReferenceTypes/HasDataSetWriter/readme.md)|Object|[&lt;DataSetWriterName&gt;](#&lt;DataSetWriterName&gt;)||[DataSetWriterType](../../Part14/ObjectTypes/DataSetWriterType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Diagnostics](#Diagnostics)||[PubSubDiagnosticsWriterGroupType](../../Part14/ObjectTypes/PubSubDiagnosticsWriterGroupType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[AddDataSetWriter](#AddDataSetWriter)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[RemoveDataSetWriter](#RemoveDataSetWriter)|||[Optional](../../Objects/Optional/readme.md)|

### <a name="AddDataSetWriter"></a>AddDataSetWriter
  
**Signature**
```
    AddDataSetWriter(
        [in]  DataSetWriterDataType Configuration
        [in]  NodeId DataSetWriterNodeId
    );
```

|Argument|Description|
|---|---|
|Configuration||
|DataSetWriterNodeId||

### <a name="RemoveDataSetWriter"></a>RemoveDataSetWriter
  
**Signature**
```
    RemoveDataSetWriter(
        [in]  NodeId DataSetWriterNodeId
    );
```

|Argument|Description|
|---|---|
|DataSetWriterNodeId||


