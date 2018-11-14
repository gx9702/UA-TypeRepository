<!-- objecttype -->
## AuditHistoryAtTimeDeleteEventType
  
<!-- end of text -->
The representation of the AuditHistoryAtTimeDeleteEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=3019|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|AuditHistoryAtTimeDeleteEventType|
|NodeClass|ObjectType|
|IsAbstract|True|
|BaseType|[AuditHistoryDeleteEventType](../../ObjectTypes/AuditHistoryDeleteEventType/readme.md)|
|Categories||

The references from the AuditHistoryAtTimeDeleteEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ReqTimes](#ReqTimes)|[UtcTime](../../DataTypes/UtcTime/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[OldValues](#OldValues)|[DataValue](../../DataTypes/DataValue/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


