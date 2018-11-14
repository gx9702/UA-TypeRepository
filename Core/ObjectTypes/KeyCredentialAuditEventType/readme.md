<!-- objecttype -->
## KeyCredentialAuditEventType
  
<!-- end of text -->
The representation of the KeyCredentialAuditEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=18011|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|KeyCredentialAuditEventType|
|NodeClass|ObjectType|
|IsAbstract|True|
|BaseType|[AuditUpdateMethodEventType](../../ObjectTypes/AuditUpdateMethodEventType/readme.md)|
|Categories||

The references from the KeyCredentialAuditEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ResourceUri](#ResourceUri)|[String](../../DataTypes/String/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[KeyCredentialUpdatedAuditEventType](#KeyCredentialUpdatedAuditEventType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[KeyCredentialDeletedAuditEventType](#KeyCredentialDeletedAuditEventType)||||


