<!-- objecttype -->
## KeyCredentialConfigurationType

The representation of the KeyCredentialConfigurationType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|KeyCredentialConfigurationType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[BaseObjectType](../../../Part5/ObjectTypes/BaseObjectType/readme.md)|

The references from the KeyCredentialConfigurationType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ResourceUri](#ResourceUri)|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ProfileUri](#ProfileUri)|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[EndpointUrls](#EndpointUrls)|[String](../../../Part3/DataTypes/String/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ServiceStatus](#ServiceStatus)|[StatusCode](../../../Part4/DataTypes/StatusCode/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[GetEncryptingKey](#GetEncryptingKey)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[UpdateCredential](#UpdateCredential)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[DeleteCredential](#DeleteCredential)|||[Optional](../../Objects/Optional/readme.md)|

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

