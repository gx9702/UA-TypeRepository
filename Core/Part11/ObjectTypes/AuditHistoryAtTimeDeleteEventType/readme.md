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
|BaseType|[AuditHistoryDeleteEventType](../../../Part11/ObjectTypes/AuditHistoryDeleteEventType/readme.md)|
|Categories|Part11|

The references from the AuditHistoryAtTimeDeleteEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ReqTimes](#ReqTimes)|[UtcTime](../../../Part3/DataTypes/UtcTime/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[OldValues](#OldValues)|[DataValue](../../../Part4/DataTypes/DataValue/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


