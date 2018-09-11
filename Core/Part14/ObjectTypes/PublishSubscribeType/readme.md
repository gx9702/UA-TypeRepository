<!-- objecttype -->
## PublishSubscribeType
An instance of this ObjectType represents the root Object for all PubSub related configuration and metadata Objects. The one instance of this ObjectType that represents the root Object is defined in 8.4. The ObjectType is formally defined in Table 103.  
<!-- end of text -->
The representation of the PublishSubscribeType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=14416|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|PublishSubscribeType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[PubSubKeyServiceType](../../../Part14/ObjectTypes/PubSubKeyServiceType/readme.md)|
|Categories|Part14|

The references from the PublishSubscribeType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasPubSubConnection](../../../Part14/ReferenceTypes/HasPubSubConnection/readme.md)|Object|[&lt;ConnectionName&gt;](#&lt;ConnectionName&gt;)||[PubSubConnectionType](../../Part14/ObjectTypes/PubSubConnectionType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[SetSecurityKeys](#SetSecurityKeys)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[AddConnection](#AddConnection)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[RemoveConnection](#RemoveConnection)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[PublishedDataSets](#PublishedDataSets)||[DataSetFolderType](../../Part14/ObjectTypes/DataSetFolderType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Status](#Status)||[PubSubStatusType](../../Part14/ObjectTypes/PubSubStatusType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Diagnostics](#Diagnostics)||[PubSubDiagnosticsRootType](../../Part14/ObjectTypes/PubSubDiagnosticsRootType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[SupportedTransportProfiles](#SupportedTransportProfiles)|[String](../../../Part3/DataTypes/String/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

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


