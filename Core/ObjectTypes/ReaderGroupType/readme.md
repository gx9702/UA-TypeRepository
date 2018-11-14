<!-- objecttype -->
## ReaderGroupType
  
<!-- end of text -->
The representation of the ReaderGroupType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=17999|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|ReaderGroupType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[PubSubGroupType](../../ObjectTypes/PubSubGroupType/readme.md)|
|Categories||

The references from the ReaderGroupType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasDataSetReader](../../ReferenceTypes/HasDataSetReader/readme.md)|Object|[&lt;DataSetReaderName&gt;](#&lt;DataSetReaderName&gt;)||[DataSetReaderType](../../ObjectTypes/DataSetReaderType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[Diagnostics](#Diagnostics)||[PubSubDiagnosticsReaderGroupType](../../ObjectTypes/PubSubDiagnosticsReaderGroupType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[TransportSettings](#TransportSettings)||[ReaderGroupTransportType](../../ObjectTypes/ReaderGroupTransportType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[MessageSettings](#MessageSettings)||[ReaderGroupMessageType](../../ObjectTypes/ReaderGroupMessageType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[AddDataSetReader](#AddDataSetReader)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[RemoveDataSetReader](#RemoveDataSetReader)|||[Optional](../../Objects/Optional/readme.md)|

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


