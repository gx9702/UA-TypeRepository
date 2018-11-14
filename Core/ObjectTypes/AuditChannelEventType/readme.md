<!-- objecttype -->
## AuditChannelEventType
A base type for events used to track related changes to a secure channel.  
<!-- end of text -->
The representation of the AuditChannelEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2059|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|AuditChannelEventType|
|NodeClass|ObjectType|
|IsAbstract|True|
|BaseType|[AuditSecurityEventType](../../ObjectTypes/AuditSecurityEventType/readme.md)|
|Categories||

The references from the AuditChannelEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[SecureChannelId](#SecureChannelId)|[String](../../DataTypes/String/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditOpenSecureChannelEventType](#AuditOpenSecureChannelEventType)||||


