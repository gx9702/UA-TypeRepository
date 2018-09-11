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
|BaseType|[BaseObjectType](../../../Part5/ObjectTypes/BaseObjectType/readme.md)|
|Categories|Part12|

The references from the CertificateGroupType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[TrustList](#TrustList)||[TrustListType](../../Part12/ObjectTypes/TrustListType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[CertificateTypes](#CertificateTypes)|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


