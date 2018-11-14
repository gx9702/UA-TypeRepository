<!-- objecttype -->
## AuditUpdateMethodEventType
  
<!-- end of text -->
The representation of the AuditUpdateMethodEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2127|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|AuditUpdateMethodEventType|
|NodeClass|ObjectType|
|IsAbstract|True|
|BaseType|[AuditEventType](../../ObjectTypes/AuditEventType/readme.md)|
|Categories||

The references from the AuditUpdateMethodEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[MethodId](#MethodId)|[NodeId](../../DataTypes/NodeId/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[InputArguments](#InputArguments)|[BaseDataType](../../DataTypes/BaseDataType/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditUpdateStateEventType](#AuditUpdateStateEventType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[RoleMappingRuleChangedAuditEventType](#RoleMappingRuleChangedAuditEventType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditConditionEventType](#AuditConditionEventType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[TrustListUpdatedAuditEventType](#TrustListUpdatedAuditEventType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[CertificateUpdatedAuditEventType](#CertificateUpdatedAuditEventType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[KeyCredentialAuditEventType](#KeyCredentialAuditEventType)||||


