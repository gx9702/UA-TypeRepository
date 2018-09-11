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
|BaseType|[AuditUpdateMethodEventType](../../../Part5/ObjectTypes/AuditUpdateMethodEventType/readme.md)|
|Categories|Part12|

The references from the KeyCredentialAuditEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ResourceUri](#ResourceUri)|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[KeyCredentialUpdatedAuditEventType](#KeyCredentialUpdatedAuditEventType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[KeyCredentialDeletedAuditEventType](#KeyCredentialDeletedAuditEventType)||||


