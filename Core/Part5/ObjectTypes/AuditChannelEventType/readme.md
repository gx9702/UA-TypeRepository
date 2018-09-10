<!-- objecttype -->
## AuditChannelEventType
The representation of the AuditChannelEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|AuditChannelEventType|
|NodeClass|ObjectType|
|IsAbtract|True|
|BaseType|[AuditSecurityEventType](../../../Part5/ObjectTypes/AuditSecurityEventType/readme.md)|

The references from the AuditChannelEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|SecureChannelId|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|AuditOpenSecureChannelEventType||||

