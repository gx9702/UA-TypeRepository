<!-- objecttype -->
## AuditHistoryValueUpdateEventType
  
<!-- end of text -->
The representation of the AuditHistoryValueUpdateEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=3006|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|AuditHistoryValueUpdateEventType|
|NodeClass|ObjectType|
|IsAbstract|True|
|BaseType|[AuditHistoryUpdateEventType](../../ObjectTypes/AuditHistoryUpdateEventType/readme.md)|
|Categories||

The references from the AuditHistoryValueUpdateEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[UpdatedNode](#UpdatedNode)|[NodeId](../../DataTypes/NodeId/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[PerformInsertReplace](#PerformInsertReplace)|[PerformUpdateType](../../DataTypes/PerformUpdateType/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[NewValues](#NewValues)|[DataValue](../../DataTypes/DataValue/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[OldValues](#OldValues)|[DataValue](../../DataTypes/DataValue/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


