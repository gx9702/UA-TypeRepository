<!-- objecttype -->
## AuditCertificateEventType
  
The representation of the AuditCertificateEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|AuditCertificateEventType|
|NodeClass|ObjectType|
|IsAbtract|True|
|BaseType|[AuditSecurityEventType](../../../Part5/ObjectTypes/AuditSecurityEventType/readme.md)|

The references from the AuditCertificateEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[Certificate](#Certificate)|[ByteString](../../../Part3/DataTypes/ByteString/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditCertificateDataMismatchEventType](#AuditCertificateDataMismatchEventType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditCertificateExpiredEventType](#AuditCertificateExpiredEventType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditCertificateInvalidEventType](#AuditCertificateInvalidEventType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditCertificateUntrustedEventType](#AuditCertificateUntrustedEventType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditCertificateRevokedEventType](#AuditCertificateRevokedEventType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditCertificateMismatchEventType](#AuditCertificateMismatchEventType)||||


