<!-- objecttype -->
## PubSubConnectionType
  
<!-- end of text -->
The representation of the PubSubConnectionType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=14209|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|PubSubConnectionType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[BaseObjectType](../../ObjectTypes/BaseObjectType/readme.md)|
|Categories||

The references from the PubSubConnectionType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[PublisherId](#PublisherId)|[BaseDataType](../../DataTypes/BaseDataType/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[TransportProfileUri](#TransportProfileUri)|[String](../../DataTypes/String/readme.md)|[SelectionListType](../../VariableTypes/SelectionListType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ConnectionProperties](#ConnectionProperties)|[KeyValuePair](../../DataTypes/KeyValuePair/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[Address](#Address)||[NetworkAddressType](../../ObjectTypes/NetworkAddressType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[TransportSettings](#TransportSettings)||[ConnectionTransportType](../../ObjectTypes/ConnectionTransportType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[&lt;WriterGroupName&gt;](#&lt;WriterGroupName&gt;)||[WriterGroupType](../../ObjectTypes/WriterGroupType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[&lt;ReaderGroupName&gt;](#&lt;ReaderGroupName&gt;)||[ReaderGroupType](../../ObjectTypes/ReaderGroupType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[Status](#Status)||[PubSubStatusType](../../ObjectTypes/PubSubStatusType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[Diagnostics](#Diagnostics)||[PubSubDiagnosticsConnectionType](../../ObjectTypes/PubSubDiagnosticsConnectionType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[AddWriterGroup](#AddWriterGroup)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[AddReaderGroup](#AddReaderGroup)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[RemoveGroup](#RemoveGroup)|||[Optional](../../Objects/Optional/readme.md)|

### <a name="AddWriterGroup"></a>AddWriterGroup
  
**Signature**
```
    AddWriterGroup(
        [in]  WriterGroupDataType Configuration
        [in]  NodeId GroupId
    );
```

|Argument|Description|
|---|---|
|Configuration||
|GroupId||

### <a name="AddReaderGroup"></a>AddReaderGroup
  
**Signature**
```
    AddReaderGroup(
        [in]  ReaderGroupDataType Configuration
        [in]  NodeId GroupId
    );
```

|Argument|Description|
|---|---|
|Configuration||
|GroupId||

### <a name="RemoveGroup"></a>RemoveGroup
  
**Signature**
```
    RemoveGroup(
        [in]  NodeId GroupId
    );
```

|Argument|Description|
|---|---|
|GroupId||


