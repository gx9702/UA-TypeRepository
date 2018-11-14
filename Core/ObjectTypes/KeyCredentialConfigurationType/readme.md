<!-- objecttype -->
## KeyCredentialConfigurationType
  
<!-- end of text -->
The representation of the KeyCredentialConfigurationType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=18001|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|KeyCredentialConfigurationType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[BaseObjectType](../../ObjectTypes/BaseObjectType/readme.md)|
|Categories||

The references from the KeyCredentialConfigurationType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ResourceUri](#ResourceUri)|[String](../../DataTypes/String/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ProfileUri](#ProfileUri)|[String](../../DataTypes/String/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[EndpointUrls](#EndpointUrls)|[String](../../DataTypes/String/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ServiceStatus](#ServiceStatus)|[StatusCode](../../DataTypes/StatusCode/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[GetEncryptingKey](#GetEncryptingKey)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[UpdateCredential](#UpdateCredential)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[DeleteCredential](#DeleteCredential)|||[Optional](../../Objects/Optional/readme.md)|

### <a name="GetEncryptingKey"></a>GetEncryptingKey
  
**Signature**
```
    GetEncryptingKey(
        [in]  String CredentialId
        [in]  String RequestedSecurityPolicyUri
        [in]  ByteString PublicKey
        [in]  NodeId RevisedSecurityPolicyUri
    );
```

|Argument|Description|
|---|---|
|CredentialId||
|RequestedSecurityPolicyUri||
|PublicKey||
|RevisedSecurityPolicyUri||

### <a name="UpdateCredential"></a>UpdateCredential
  
**Signature**
```
    UpdateCredential(
        [in]  String CredentialId
        [in]  ByteString CredentialSecret
        [in]  String CertificateThumbprint
        [in]  String SecurityPolicyUri
    );
```

|Argument|Description|
|---|---|
|CredentialId||
|CredentialSecret||
|CertificateThumbprint||
|SecurityPolicyUri||

### <a name="DeleteCredential"></a>DeleteCredential
  
**Signature**
```
    DeleteCredential(    );
```

