<!-- objecttype -->
## AuditActivateSessionEventType
  
<!-- end of text -->
The representation of the AuditActivateSessionEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2075|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|AuditActivateSessionEventType|
|NodeClass|ObjectType|
|IsAbstract|True|
|BaseType|[AuditSessionEventType](../../../Part5/ObjectTypes/AuditSessionEventType/readme.md)|
|Categories|Part5|

The references from the AuditActivateSessionEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ClientSoftwareCertificates](#ClientSoftwareCertificates)|[SignedSoftwareCertificate](../../../Part4/DataTypes/SignedSoftwareCertificate/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[UserIdentityToken](#UserIdentityToken)|[UserIdentityToken](../../../Part4/DataTypes/UserIdentityToken/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[SecureChannelId](#SecureChannelId)|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


