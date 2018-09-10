<!-- objecttype -->
## AuditEventType
A base type for events used to track client initiated changes to the server state.  
The representation of the AuditEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|AuditEventType|
|NodeClass|ObjectType|
|IsAbtract|True|
|BaseType|[BaseEventType](../../../Part5/ObjectTypes/BaseEventType/readme.md)|

The references from the AuditEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ActionTimeStamp](#ActionTimeStamp)|[UtcTime](../../../Part3/DataTypes/UtcTime/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[Status](#Status)|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ServerId](#ServerId)|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ClientAuditEntryId](#ClientAuditEntryId)|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ClientUserId](#ClientUserId)|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditSecurityEventType](#AuditSecurityEventType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditNodeManagementEventType](#AuditNodeManagementEventType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditUpdateEventType](#AuditUpdateEventType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditUpdateMethodEventType](#AuditUpdateMethodEventType)||||


