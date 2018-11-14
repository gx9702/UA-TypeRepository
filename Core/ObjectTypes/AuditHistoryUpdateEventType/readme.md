<!-- objecttype -->
## AuditHistoryUpdateEventType
  
<!-- end of text -->
The representation of the AuditHistoryUpdateEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2104|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|AuditHistoryUpdateEventType|
|NodeClass|ObjectType|
|IsAbstract|True|
|BaseType|[AuditUpdateEventType](../../ObjectTypes/AuditUpdateEventType/readme.md)|
|Categories||

The references from the AuditHistoryUpdateEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ParameterDataTypeId](#ParameterDataTypeId)|[NodeId](../../DataTypes/NodeId/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditHistoryEventUpdateEventType](#AuditHistoryEventUpdateEventType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditHistoryValueUpdateEventType](#AuditHistoryValueUpdateEventType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditHistoryDeleteEventType](#AuditHistoryDeleteEventType)||||


