<!-- objecttype -->
## TrustListType
  
<!-- end of text -->
The representation of the TrustListType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=12522|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|TrustListType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[FileType](../../ObjectTypes/FileType/readme.md)|
|Categories||

The references from the TrustListType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[LastUpdateTime](#LastUpdateTime)|[UtcTime](../../DataTypes/UtcTime/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[OpenWithMasks](#OpenWithMasks)|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[CloseAndUpdate](#CloseAndUpdate)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[AddCertificate](#AddCertificate)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[RemoveCertificate](#RemoveCertificate)|||[Optional](../../Objects/Optional/readme.md)|

### <a name="OpenWithMasks"></a>OpenWithMasks
  
**Signature**
```
    OpenWithMasks(
        [in]  UInt32 Masks
        [in]  UInt32 FileHandle
    );
```

|Argument|Description|
|---|---|
|Masks||
|FileHandle||

### <a name="CloseAndUpdate"></a>CloseAndUpdate
  
**Signature**
```
    CloseAndUpdate(
        [in]  UInt32 FileHandle
        [in]  Boolean ApplyChangesRequired
    );
```

|Argument|Description|
|---|---|
|FileHandle||
|ApplyChangesRequired||

### <a name="AddCertificate"></a>AddCertificate
  
**Signature**
```
    AddCertificate(
        [in]  ByteString Certificate
        [in]  Boolean IsTrustedCertificate
    );
```

|Argument|Description|
|---|---|
|Certificate||
|IsTrustedCertificate||

### <a name="RemoveCertificate"></a>RemoveCertificate
  
**Signature**
```
    RemoveCertificate(
        [in]  String Thumbprint
        [in]  Boolean IsTrustedCertificate
    );
```

|Argument|Description|
|---|---|
|Thumbprint||
|IsTrustedCertificate||


