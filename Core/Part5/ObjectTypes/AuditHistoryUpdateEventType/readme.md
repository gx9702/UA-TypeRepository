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
|BaseType|[AuditUpdateEventType](../../../Part5/ObjectTypes/AuditUpdateEventType/readme.md)|
|Categories|Part5|

The references from the AuditHistoryUpdateEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ParameterDataTypeId](#ParameterDataTypeId)|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditHistoryEventUpdateEventType](#AuditHistoryEventUpdateEventType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditHistoryValueUpdateEventType](#AuditHistoryValueUpdateEventType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditHistoryDeleteEventType](#AuditHistoryDeleteEventType)||||


