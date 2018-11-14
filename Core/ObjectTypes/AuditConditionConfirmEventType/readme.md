<!-- objecttype -->
## AuditConditionConfirmEventType
  
<!-- end of text -->
The representation of the AuditConditionConfirmEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=8961|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|AuditConditionConfirmEventType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[AuditConditionEventType](../../ObjectTypes/AuditConditionEventType/readme.md)|
|Categories||

The references from the AuditConditionConfirmEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ConditionEventId](#ConditionEventId)|[ByteString](../../DataTypes/ByteString/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[Comment](#Comment)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


