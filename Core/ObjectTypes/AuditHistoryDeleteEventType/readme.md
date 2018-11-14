<!-- objecttype -->
## AuditHistoryDeleteEventType
  
<!-- end of text -->
The representation of the AuditHistoryDeleteEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=3012|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|AuditHistoryDeleteEventType|
|NodeClass|ObjectType|
|IsAbstract|True|
|BaseType|[AuditHistoryUpdateEventType](../../ObjectTypes/AuditHistoryUpdateEventType/readme.md)|
|Categories||

The references from the AuditHistoryDeleteEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[UpdatedNode](#UpdatedNode)|[NodeId](../../DataTypes/NodeId/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditHistoryRawModifyDeleteEventType](#AuditHistoryRawModifyDeleteEventType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditHistoryAtTimeDeleteEventType](#AuditHistoryAtTimeDeleteEventType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditHistoryEventDeleteEventType](#AuditHistoryEventDeleteEventType)||||


