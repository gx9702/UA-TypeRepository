<!-- objecttype -->
## AuditWriteUpdateEventType
  
<!-- end of text -->
The representation of the AuditWriteUpdateEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2100|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|AuditWriteUpdateEventType|
|NodeClass|ObjectType|
|IsAbstract|True|
|BaseType|[AuditUpdateEventType](../../ObjectTypes/AuditUpdateEventType/readme.md)|
|Categories||

The references from the AuditWriteUpdateEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[AttributeId](#AttributeId)|[UInt32](../../DataTypes/UInt32/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[IndexRange](#IndexRange)|[NumericRange](../../DataTypes/NumericRange/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[OldValue](#OldValue)|[BaseDataType](../../DataTypes/BaseDataType/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[NewValue](#NewValue)|[BaseDataType](../../DataTypes/BaseDataType/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


