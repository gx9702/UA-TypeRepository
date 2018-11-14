<!-- objecttype -->
## AuditSecurityEventType
A base type for events used to track security related changes.  
<!-- end of text -->
The representation of the AuditSecurityEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2058|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|AuditSecurityEventType|
|NodeClass|ObjectType|
|IsAbstract|True|
|BaseType|[AuditEventType](../../ObjectTypes/AuditEventType/readme.md)|
|Categories||

The references from the AuditSecurityEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[StatusCodeId](#StatusCodeId)|[StatusCode](../../DataTypes/StatusCode/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditChannelEventType](#AuditChannelEventType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditSessionEventType](#AuditSessionEventType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditCertificateEventType](#AuditCertificateEventType)||||


