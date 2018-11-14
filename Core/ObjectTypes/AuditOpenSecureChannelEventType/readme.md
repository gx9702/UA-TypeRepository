<!-- objecttype -->
## AuditOpenSecureChannelEventType
An event that is raised when a secure channel is opened.  
<!-- end of text -->
The representation of the AuditOpenSecureChannelEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2060|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|AuditOpenSecureChannelEventType|
|NodeClass|ObjectType|
|IsAbstract|True|
|BaseType|[AuditChannelEventType](../../ObjectTypes/AuditChannelEventType/readme.md)|
|Categories||

The references from the AuditOpenSecureChannelEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ClientCertificate](#ClientCertificate)|[ByteString](../../DataTypes/ByteString/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ClientCertificateThumbprint](#ClientCertificateThumbprint)|[String](../../DataTypes/String/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[RequestType](#RequestType)|[SecurityTokenRequestType](../../DataTypes/SecurityTokenRequestType/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[SecurityPolicyUri](#SecurityPolicyUri)|[String](../../DataTypes/String/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[SecurityMode](#SecurityMode)|[MessageSecurityMode](../../DataTypes/MessageSecurityMode/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[RequestedLifetime](#RequestedLifetime)|[Duration](../../DataTypes/Duration/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


