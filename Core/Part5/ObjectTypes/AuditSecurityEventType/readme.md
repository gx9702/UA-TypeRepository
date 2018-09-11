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
|BaseType|[AuditEventType](../../../Part5/ObjectTypes/AuditEventType/readme.md)|
|Categories|Part5|

The references from the AuditSecurityEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[StatusCodeId](#StatusCodeId)|[StatusCode](../../../Part4/DataTypes/StatusCode/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditChannelEventType](#AuditChannelEventType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditSessionEventType](#AuditSessionEventType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditCertificateEventType](#AuditCertificateEventType)||||


