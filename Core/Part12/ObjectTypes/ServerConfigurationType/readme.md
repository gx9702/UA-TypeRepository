<!-- objecttype -->
## ServerConfigurationType
  
The representation of the ServerConfigurationType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|ServerConfigurationType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[BaseObjectType](../../../Part5/ObjectTypes/BaseObjectType/readme.md)|

The references from the ServerConfigurationType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[CertificateGroups](#CertificateGroups)||[CertificateGroupFolderType](../../Part12/ObjectTypes/CertificateGroupFolderType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ServerCapabilities](#ServerCapabilities)|[String](../../../Part3/DataTypes/String/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[SupportedPrivateKeyFormats](#SupportedPrivateKeyFormats)|[String](../../../Part3/DataTypes/String/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[MaxTrustListSize](#MaxTrustListSize)|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[MulticastDnsEnabled](#MulticastDnsEnabled)|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[UpdateCertificate](#UpdateCertificate)|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[ApplyChanges](#ApplyChanges)|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[CreateSigningRequest](#CreateSigningRequest)|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[GetRejectedList](#GetRejectedList)|||[Mandatory](../../Objects/Mandatory/readme.md)|

### <a name="UpdateCertificate"></a>UpdateCertificate
  
**Signature**
```
    UpdateCertificate(
        [in]  NodeId CertificateGroupId
        [in]  NodeId CertificateTypeId
        [in]  ByteString Certificate
        [in]  ByteString IssuerCertificates
        [in]  String PrivateKeyFormat
        [in]  ByteString PrivateKey
        [in]  Boolean ApplyChangesRequired
    );
```

|Argument|Description|
|---|---|
|CertificateGroupId||
|CertificateTypeId||
|Certificate||
|IssuerCertificates||
|PrivateKeyFormat||
|PrivateKey||
|ApplyChangesRequired||

### <a name="ApplyChanges"></a>ApplyChanges
  
**Signature**
```
    ApplyChanges(    );
```
### <a name="CreateSigningRequest"></a>CreateSigningRequest
  
**Signature**
```
    CreateSigningRequest(
        [in]  NodeId CertificateGroupId
        [in]  NodeId CertificateTypeId
        [in]  String SubjectName
        [in]  Boolean RegeneratePrivateKey
        [in]  ByteString Nonce
        [in]  ByteString CertificateRequest
    );
```

|Argument|Description|
|---|---|
|CertificateGroupId||
|CertificateTypeId||
|SubjectName||
|RegeneratePrivateKey||
|Nonce||
|CertificateRequest||

### <a name="GetRejectedList"></a>GetRejectedList
  
**Signature**
```
    GetRejectedList(
        [in]  ByteString Certificates
    );
```

|Argument|Description|
|---|---|
|Certificates||


