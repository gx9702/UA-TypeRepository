<!-- objecttype -->
## ReaderGroupType
  
The representation of the ReaderGroupType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|ReaderGroupType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[PubSubGroupType](../../../Part14/ObjectTypes/PubSubGroupType/readme.md)|

The references from the ReaderGroupType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasDataSetReader](../../../Part14/ReferenceTypes/HasDataSetReader/readme.md)|Object|[&lt;DataSetReaderName&gt;](#&lt;DataSetReaderName&gt;)||[DataSetReaderType](../../Part14/ObjectTypes/DataSetReaderType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Diagnostics](#Diagnostics)||[PubSubDiagnosticsReaderGroupType](../../Part14/ObjectTypes/PubSubDiagnosticsReaderGroupType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[TransportSettings](#TransportSettings)||[ReaderGroupTransportType](../../Part14/ObjectTypes/ReaderGroupTransportType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[MessageSettings](#MessageSettings)||[ReaderGroupMessageType](../../Part14/ObjectTypes/ReaderGroupMessageType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[AddDataSetReader](#AddDataSetReader)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[RemoveDataSetReader](#RemoveDataSetReader)|||[Optional](../../Objects/Optional/readme.md)|

### <a name="AddDataSetReader"></a>AddDataSetReader
  
**Signature**
```
    AddDataSetReader(
        [in]  DataSetReaderDataType Configuration
        [in]  NodeId DataSetReaderNodeId
    );
```

|Argument|Description|
|---|---|
|Configuration||
|DataSetReaderNodeId||

### <a name="RemoveDataSetReader"></a>RemoveDataSetReader
  
**Signature**
```
    RemoveDataSetReader(
        [in]  NodeId DataSetReaderNodeId
    );
```

|Argument|Description|
|---|---|
|DataSetReaderNodeId||


