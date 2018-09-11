<!-- objecttype -->
## AuditConditionCommentEventType
  
<!-- end of text -->
The representation of the AuditConditionCommentEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2829|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|AuditConditionCommentEventType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[AuditConditionEventType](../../../Part9/ObjectTypes/AuditConditionEventType/readme.md)|
|Categories|Part9|

The references from the AuditConditionCommentEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ConditionEventId](#ConditionEventId)|[ByteString](../../../Part3/DataTypes/ByteString/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[Comment](#Comment)|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


