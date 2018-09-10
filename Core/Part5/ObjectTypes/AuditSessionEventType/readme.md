<!-- objecttype -->
## AuditSessionEventType
A base type for events used to track related changes to a session.
The representation of the AuditSessionEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|AuditSessionEventType|
|NodeClass|ObjectType|
|IsAbtract|True|
|BaseType|[AuditSecurityEventType](../../../Part5/ObjectTypes/AuditSecurityEventType/readme.md)|

The references from the AuditSessionEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[SessionId](#SessionId)|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditCreateSessionEventType](#AuditCreateSessionEventType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditActivateSessionEventType](#AuditActivateSessionEventType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditCancelEventType](#AuditCancelEventType)||||


