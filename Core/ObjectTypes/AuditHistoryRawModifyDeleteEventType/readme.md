<!-- objecttype -->
## AuditHistoryRawModifyDeleteEventType
  
<!-- end of text -->
The representation of the AuditHistoryRawModifyDeleteEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=3014|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|AuditHistoryRawModifyDeleteEventType|
|NodeClass|ObjectType|
|IsAbstract|True|
|BaseType|[AuditHistoryDeleteEventType](../../ObjectTypes/AuditHistoryDeleteEventType/readme.md)|
|Categories||

The references from the AuditHistoryRawModifyDeleteEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[IsDeleteModified](#IsDeleteModified)|[Boolean](../../DataTypes/Boolean/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[StartTime](#StartTime)|[UtcTime](../../DataTypes/UtcTime/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[EndTime](#EndTime)|[UtcTime](../../DataTypes/UtcTime/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[OldValues](#OldValues)|[DataValue](../../DataTypes/DataValue/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


