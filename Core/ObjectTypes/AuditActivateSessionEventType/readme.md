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
|BaseType|[AuditSessionEventType](../../ObjectTypes/AuditSessionEventType/readme.md)|
|Categories||

The references from the AuditActivateSessionEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ClientSoftwareCertificates](#ClientSoftwareCertificates)|[SignedSoftwareCertificate](../../DataTypes/SignedSoftwareCertificate/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[UserIdentityToken](#UserIdentityToken)|[UserIdentityToken](../../DataTypes/UserIdentityToken/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[SecureChannelId](#SecureChannelId)|[String](../../DataTypes/String/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


