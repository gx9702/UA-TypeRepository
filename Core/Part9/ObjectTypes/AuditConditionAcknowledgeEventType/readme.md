<!-- objecttype -->
## AuditConditionAcknowledgeEventType

The representation of the AuditConditionAcknowledgeEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|AuditConditionAcknowledgeEventType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[AuditConditionEventType](../../../Part9/ObjectTypes/AuditConditionEventType/readme.md)|

The references from the AuditConditionAcknowledgeEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ConditionEventId](#ConditionEventId)|[ByteString](../../../Part3/DataTypes/ByteString/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[Comment](#Comment)|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


