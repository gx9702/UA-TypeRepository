<!-- objecttype -->
## AuditHistoryRawModifyDeleteEventType
  
The representation of the AuditHistoryRawModifyDeleteEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|AuditHistoryRawModifyDeleteEventType|
|NodeClass|ObjectType|
|IsAbtract|True|
|BaseType|[AuditHistoryDeleteEventType](../../../Part11/ObjectTypes/AuditHistoryDeleteEventType/readme.md)|

The references from the AuditHistoryRawModifyDeleteEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[IsDeleteModified](#IsDeleteModified)|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[StartTime](#StartTime)|[UtcTime](../../../Part3/DataTypes/UtcTime/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[EndTime](#EndTime)|[UtcTime](../../../Part3/DataTypes/UtcTime/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[OldValues](#OldValues)|[DataValue](../../../Part4/DataTypes/DataValue/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


