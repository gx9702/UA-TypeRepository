<!-- objecttype -->
## PublishSubscribeType
  
<!-- end of text -->
The representation of the PublishSubscribeType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=14416|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|PublishSubscribeType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[PubSubKeyServiceType](../../ObjectTypes/PubSubKeyServiceType/readme.md)|
|Categories||

The references from the PublishSubscribeType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasPubSubConnection](../../ReferenceTypes/HasPubSubConnection/readme.md)|Object|[&lt;ConnectionName&gt;](#&lt;ConnectionName&gt;)||[PubSubConnectionType](../../ObjectTypes/PubSubConnectionType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[SetSecurityKeys](#SetSecurityKeys)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[AddConnection](#AddConnection)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[RemoveConnection](#RemoveConnection)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[PublishedDataSets](#PublishedDataSets)||[DataSetFolderType](../../ObjectTypes/DataSetFolderType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[Status](#Status)||[PubSubStatusType](../../ObjectTypes/PubSubStatusType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[Diagnostics](#Diagnostics)||[PubSubDiagnosticsRootType](../../ObjectTypes/PubSubDiagnosticsRootType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[SupportedTransportProfiles](#SupportedTransportProfiles)|[String](../../DataTypes/String/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

### <a name="SetSecurityKeys"></a>SetSecurityKeys
  
**Signature**
```
    SetSecurityKeys(
        [in]  String SecurityGroupId
        [in]  String SecurityPolicyUri
        [in]  IntegerId CurrentTokenId
        [in]  ByteString CurrentKey
        [in]  ByteString FutureKeys
        [in]  Duration TimeToNextKey
        [in]  Duration KeyLifetime
    );
```

|Argument|Description|
|---|---|
|SecurityGroupId||
|SecurityPolicyUri||
|CurrentTokenId||
|CurrentKey||
|FutureKeys||
|TimeToNextKey||
|KeyLifetime||

### <a name="AddConnection"></a>AddConnection
  
**Signature**
```
    AddConnection(
        [in]  PubSubConnectionDataType Configuration
        [in]  NodeId ConnectionId
    );
```

|Argument|Description|
|---|---|
|Configuration||
|ConnectionId||

### <a name="RemoveConnection"></a>RemoveConnection
  
**Signature**
```
    RemoveConnection(
        [in]  NodeId ConnectionId
    );
```

|Argument|Description|
|---|---|
|ConnectionId||


