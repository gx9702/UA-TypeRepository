<!-- objecttype -->
## CertificateGroupType
  
<!-- end of text -->
The representation of the CertificateGroupType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=12555|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|CertificateGroupType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[BaseObjectType](../../ObjectTypes/BaseObjectType/readme.md)|
|Categories||

The references from the CertificateGroupType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[TrustList](#TrustList)||[TrustListType](../../ObjectTypes/TrustListType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[CertificateTypes](#CertificateTypes)|[NodeId](../../DataTypes/NodeId/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


