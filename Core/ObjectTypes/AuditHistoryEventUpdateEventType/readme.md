<!-- objecttype -->
## AuditHistoryEventUpdateEventType
  
<!-- end of text -->
The representation of the AuditHistoryEventUpdateEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2999|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|AuditHistoryEventUpdateEventType|
|NodeClass|ObjectType|
|IsAbstract|True|
|BaseType|[AuditHistoryUpdateEventType](../../ObjectTypes/AuditHistoryUpdateEventType/readme.md)|
|Categories||

The references from the AuditHistoryEventUpdateEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[UpdatedNode](#UpdatedNode)|[NodeId](../../DataTypes/NodeId/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[PerformInsertReplace](#PerformInsertReplace)|[PerformUpdateType](../../DataTypes/PerformUpdateType/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[Filter](#Filter)|[EventFilter](../../DataTypes/EventFilter/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[NewValues](#NewValues)|[HistoryEventFieldList](../../DataTypes/HistoryEventFieldList/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[OldValues](#OldValues)|[HistoryEventFieldList](../../DataTypes/HistoryEventFieldList/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


