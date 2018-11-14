<!-- objecttype -->
## KeyCredentialConfigurationFolderType
  
<!-- end of text -->
The representation of the KeyCredentialConfigurationFolderType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=17496|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|KeyCredentialConfigurationFolderType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[FolderType](../../ObjectTypes/FolderType/readme.md)|
|Categories||

The references from the KeyCredentialConfigurationFolderType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[&lt;ServiceName&gt;](#&lt;ServiceName&gt;)||[KeyCredentialConfigurationType](../../ObjectTypes/KeyCredentialConfigurationType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[CreateCredential](#CreateCredential)|||[Optional](../../Objects/Optional/readme.md)|

### <a name="CreateCredential"></a>CreateCredential
  
**Signature**
```
    CreateCredential(
        [in]  String ResourceUri
        [in]  String ProfileUri
        [in]  String EndpointUrls
        [in]  NodeId CredentialNodeId
    );
```

|Argument|Description|
|---|---|
|ResourceUri||
|ProfileUri||
|EndpointUrls||
|CredentialNodeId||


