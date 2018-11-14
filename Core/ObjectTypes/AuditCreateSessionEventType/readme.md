<!-- objecttype -->
## AuditCreateSessionEventType
An event that is raised when a session is created.  
<!-- end of text -->
The representation of the AuditCreateSessionEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2071|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|AuditCreateSessionEventType|
|NodeClass|ObjectType|
|IsAbstract|True|
|BaseType|[AuditSessionEventType](../../ObjectTypes/AuditSessionEventType/readme.md)|
|Categories||

The references from the AuditCreateSessionEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[SecureChannelId](#SecureChannelId)|[String](../../DataTypes/String/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ClientCertificate](#ClientCertificate)|[ByteString](../../DataTypes/ByteString/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ClientCertificateThumbprint](#ClientCertificateThumbprint)|[String](../../DataTypes/String/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[RevisedSessionTimeout](#RevisedSessionTimeout)|[Duration](../../DataTypes/Duration/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AuditUrlMismatchEventType](#AuditUrlMismatchEventType)||||


