<!-- objecttype -->
## CertificateGroupFolderType
  
<!-- end of text -->
The representation of the CertificateGroupFolderType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=13813|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|CertificateGroupFolderType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[FolderType](../../../Part5/ObjectTypes/FolderType/readme.md)|
|Categories|Part12|

The references from the CertificateGroupFolderType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[DefaultApplicationGroup](#DefaultApplicationGroup)||[CertificateGroupType](../../Part12/ObjectTypes/CertificateGroupType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[DefaultHttpsGroup](#DefaultHttpsGroup)||[CertificateGroupType](../../Part12/ObjectTypes/CertificateGroupType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[DefaultUserTokenGroup](#DefaultUserTokenGroup)||[CertificateGroupType](../../Part12/ObjectTypes/CertificateGroupType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[Organizes](../../../Part3/ReferenceTypes/Organizes/readme.md)|Object|[&lt;AdditionalGroup&gt;](#&lt;AdditionalGroup&gt;)||[CertificateGroupType](../../Part12/ObjectTypes/CertificateGroupType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|


