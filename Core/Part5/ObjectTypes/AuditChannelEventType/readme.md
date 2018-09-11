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
|BaseType|[AuditSecurityEventType](../../../Part5/ObjectTypes/AuditSecurityEventType/readme.md)|
|Categories|Part5|

The references from the AuditChannelEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[SecureChannelId](#SecureChannelId)|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditOpenSecureChannelEventType](#AuditOpenSecureChannelEventType)||||


