<!-- objecttype -->
## AuditUpdateStateEventType
  
The representation of the AuditUpdateStateEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|AuditUpdateStateEventType|
|NodeClass|ObjectType|
|IsAbtract|True|
|BaseType|[AuditUpdateMethodEventType](../../../Part5/ObjectTypes/AuditUpdateMethodEventType/readme.md)|

The references from the AuditUpdateStateEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[OldStateId](#OldStateId)|[BaseDataType](../../../Part3/DataTypes/BaseDataType/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[NewStateId](#NewStateId)|[BaseDataType](../../../Part3/DataTypes/BaseDataType/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditProgramTransitionEventType](#AuditProgramTransitionEventType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[ProgramTransitionAuditEventType](#ProgramTransitionAuditEventType)||||


