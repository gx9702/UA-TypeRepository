<!-- objecttype -->
## AuditSecurityEventType
The representation of the AuditSecurityEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|AuditSecurityEventType|
|NodeClass|ObjectType|
|IsAbtract|True|
|BaseType|[AuditEventType](../../../Part5/ObjectTypes/AuditEventType/readme.md)|

The references from the AuditSecurityEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|StatusCodeId|[StatusCode](../../../Part4/DataTypes/StatusCode/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|AuditChannelEventType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|AuditSessionEventType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|AuditCertificateEventType||||

