<!-- objecttype -->
## AuditUpdateStateEventType
  
<!-- end of text -->
The representation of the AuditUpdateStateEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2315|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|AuditUpdateStateEventType|
|NodeClass|ObjectType|
|IsAbstract|True|
|BaseType|[AuditUpdateMethodEventType](../../ObjectTypes/AuditUpdateMethodEventType/readme.md)|
|Categories||

The references from the AuditUpdateStateEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[OldStateId](#OldStateId)|[BaseDataType](../../DataTypes/BaseDataType/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[NewStateId](#NewStateId)|[BaseDataType](../../DataTypes/BaseDataType/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditProgramTransitionEventType](#AuditProgramTransitionEventType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[ProgramTransitionAuditEventType](#ProgramTransitionAuditEventType)||||


