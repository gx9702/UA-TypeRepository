<!-- objecttype -->
## AuditDeleteReferencesEventType
  
<!-- end of text -->
The representation of the AuditDeleteReferencesEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2097|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|AuditDeleteReferencesEventType|
|NodeClass|ObjectType|
|IsAbstract|True|
|BaseType|[AuditNodeManagementEventType](../../ObjectTypes/AuditNodeManagementEventType/readme.md)|
|Categories||

The references from the AuditDeleteReferencesEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ReferencesToDelete](#ReferencesToDelete)|[DeleteReferencesItem](../../DataTypes/DeleteReferencesItem/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


