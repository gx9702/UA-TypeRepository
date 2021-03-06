<!-- objecttype -->
## PubSubKeyServiceType
  
<!-- end of text -->
The representation of the PubSubKeyServiceType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15906|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|PubSubKeyServiceType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[BaseObjectType](../../ObjectTypes/BaseObjectType/readme.md)|
|Categories||

The references from the PubSubKeyServiceType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[GetSecurityKeys](#GetSecurityKeys)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[GetSecurityGroup](#GetSecurityGroup)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[SecurityGroups](#SecurityGroups)||[SecurityGroupFolderType](../../ObjectTypes/SecurityGroupFolderType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[PublishSubscribeType](#PublishSubscribeType)||||

### <a name="GetSecurityKeys"></a>GetSecurityKeys
  
**Signature**
```
    GetSecurityKeys(
        [in]  String SecurityGroupId
        [in]  IntegerId StartingTokenId
        [in]  UInt32 RequestedKeyCount
        [in]  String SecurityPolicyUri
        [in]  IntegerId FirstTokenId
        [in]  ByteString Keys
        [in]  Duration TimeToNextKey
        [in]  Duration KeyLifetime
    );
```

|Argument|Description|
|---|---|
|SecurityGroupId||
|StartingTokenId||
|RequestedKeyCount||
|SecurityPolicyUri||
|FirstTokenId||
|Keys||
|TimeToNextKey||
|KeyLifetime||

### <a name="GetSecurityGroup"></a>GetSecurityGroup
  
**Signature**
```
    GetSecurityGroup(
        [in]  String SecurityGroupId
        [in]  NodeId SecurityGroupNodeId
    );
```

|Argument|Description|
|---|---|
|SecurityGroupId||
|SecurityGroupNodeId||


