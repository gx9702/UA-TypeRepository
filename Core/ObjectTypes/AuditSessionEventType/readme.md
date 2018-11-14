<!-- objecttype -->
## AuditSessionEventType
A base type for events used to track related changes to a session.  
<!-- end of text -->
The representation of the AuditSessionEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2069|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|AuditSessionEventType|
|NodeClass|ObjectType|
|IsAbstract|True|
|BaseType|[AuditSecurityEventType](../../ObjectTypes/AuditSecurityEventType/readme.md)|
|Categories||

The references from the AuditSessionEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[SessionId](#SessionId)|[NodeId](../../DataTypes/NodeId/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditCreateSessionEventType](#AuditCreateSessionEventType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditActivateSessionEventType](#AuditActivateSessionEventType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditCancelEventType](#AuditCancelEventType)||||


