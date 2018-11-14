<!-- objecttype -->
## WriterGroupType
  
<!-- end of text -->
The representation of the WriterGroupType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=17725|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|WriterGroupType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[PubSubGroupType](../../ObjectTypes/PubSubGroupType/readme.md)|
|Categories||

The references from the WriterGroupType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[WriterGroupId](#WriterGroupId)|[UInt16](../../DataTypes/UInt16/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[PublishingInterval](#PublishingInterval)|[Duration](../../DataTypes/Duration/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[KeepAliveTime](#KeepAliveTime)|[Duration](../../DataTypes/Duration/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[Priority](#Priority)|[Byte](../../DataTypes/Byte/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[LocaleIds](#LocaleIds)|[LocaleId](../../DataTypes/LocaleId/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[HeaderLayoutUri](#HeaderLayoutUri)|[String](../../DataTypes/String/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[TransportSettings](#TransportSettings)||[WriterGroupTransportType](../../ObjectTypes/WriterGroupTransportType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[MessageSettings](#MessageSettings)||[WriterGroupMessageType](../../ObjectTypes/WriterGroupMessageType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasDataSetWriter](../../ReferenceTypes/HasDataSetWriter/readme.md)|Object|[&lt;DataSetWriterName&gt;](#&lt;DataSetWriterName&gt;)||[DataSetWriterType](../../ObjectTypes/DataSetWriterType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[Diagnostics](#Diagnostics)||[PubSubDiagnosticsWriterGroupType](../../ObjectTypes/PubSubDiagnosticsWriterGroupType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[AddDataSetWriter](#AddDataSetWriter)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[RemoveDataSetWriter](#RemoveDataSetWriter)|||[Optional](../../Objects/Optional/readme.md)|

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


