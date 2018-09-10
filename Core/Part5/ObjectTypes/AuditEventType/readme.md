<!-- objecttype -->
## AuditEventType
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
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|ActionTimeStamp||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|Status||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|ServerId||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|ClientAuditEntryId||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|ClientUserId||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|AuditSecurityEventType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|AuditNodeManagementEventType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|AuditUpdateEventType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|AuditUpdateMethodEventType||||

