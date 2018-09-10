<!-- objecttype -->
## AuditUpdateMethodEventType

The representation of the AuditUpdateMethodEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|AuditUpdateMethodEventType|
|NodeClass|ObjectType|
|IsAbtract|True|
|BaseType|[AuditEventType](../../../Part5/ObjectTypes/AuditEventType/readme.md)|

The references from the AuditUpdateMethodEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[MethodId](#MethodId)|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[InputArguments](#InputArguments)|[BaseDataType](../../../Part3/DataTypes/BaseDataType/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditUpdateStateEventType](#AuditUpdateStateEventType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[RoleMappingRuleChangedAuditEventType](#RoleMappingRuleChangedAuditEventType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditConditionEventType](#AuditConditionEventType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[TrustListUpdatedAuditEventType](#TrustListUpdatedAuditEventType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[CertificateUpdatedAuditEventType](#CertificateUpdatedAuditEventType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[KeyCredentialAuditEventType](#KeyCredentialAuditEventType)||||


