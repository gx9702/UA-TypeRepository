<!-- objecttype -->
## AuditHistoryEventDeleteEventType
  
<!-- end of text -->
The representation of the AuditHistoryEventDeleteEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=3022|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|AuditHistoryEventDeleteEventType|
|NodeClass|ObjectType|
|IsAbstract|True|
|BaseType|[AuditHistoryDeleteEventType](../../ObjectTypes/AuditHistoryDeleteEventType/readme.md)|
|Categories||

The references from the AuditHistoryEventDeleteEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[EventIds](#EventIds)|[ByteString](../../DataTypes/ByteString/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[OldValues](#OldValues)|[HistoryEventFieldList](../../DataTypes/HistoryEventFieldList/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


