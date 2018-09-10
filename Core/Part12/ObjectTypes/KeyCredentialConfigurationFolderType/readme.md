<!-- objecttype -->
## KeyCredentialConfigurationFolderType
  
The representation of the KeyCredentialConfigurationFolderType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|KeyCredentialConfigurationFolderType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[FolderType](../../../Part5/ObjectTypes/FolderType/readme.md)|

The references from the KeyCredentialConfigurationFolderType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[&lt;ServiceName&gt;](#&lt;ServiceName&gt;)||[KeyCredentialConfigurationType](../../Part12/ObjectTypes/KeyCredentialConfigurationType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[CreateCredential](#CreateCredential)|||[Optional](../../Objects/Optional/readme.md)|

### <a name="CreateCredential"></a>CreateCredential
  
**Signature**
```
    CreateCredential(
        [in]  String ResourceUri
        [in]  String ProfileUri
        [in]  String EndpointUrls
        [in]  NodeId ObjectId
    );
```

|Argument|Description|
|---|---|
|ResourceUri||
|ProfileUri||
|EndpointUrls||
|ObjectId||

