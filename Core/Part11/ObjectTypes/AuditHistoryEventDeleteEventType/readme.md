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
|BaseType|[AuditHistoryDeleteEventType](../../../Part11/ObjectTypes/AuditHistoryDeleteEventType/readme.md)|
|Categories|Part11|

The references from the AuditHistoryEventDeleteEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[EventIds](#EventIds)|[ByteString](../../../Part3/DataTypes/ByteString/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[OldValues](#OldValues)|[HistoryEventFieldList](../../../Part4/DataTypes/HistoryEventFieldList/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


