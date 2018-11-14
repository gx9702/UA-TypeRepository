<!-- objecttype -->
## AuditCertificateEventType
  
<!-- end of text -->
The representation of the AuditCertificateEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2080|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|AuditCertificateEventType|
|NodeClass|ObjectType|
|IsAbstract|True|
|BaseType|[AuditSecurityEventType](../../ObjectTypes/AuditSecurityEventType/readme.md)|
|Categories||

The references from the AuditCertificateEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[Certificate](#Certificate)|[ByteString](../../DataTypes/ByteString/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditCertificateDataMismatchEventType](#AuditCertificateDataMismatchEventType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditCertificateExpiredEventType](#AuditCertificateExpiredEventType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditCertificateInvalidEventType](#AuditCertificateInvalidEventType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditCertificateUntrustedEventType](#AuditCertificateUntrustedEventType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditCertificateRevokedEventType](#AuditCertificateRevokedEventType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditCertificateMismatchEventType](#AuditCertificateMismatchEventType)||||


