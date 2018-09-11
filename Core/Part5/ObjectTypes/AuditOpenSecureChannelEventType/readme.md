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
|BaseType|[AuditChannelEventType](../../../Part5/ObjectTypes/AuditChannelEventType/readme.md)|
|Categories|Part5|

The references from the AuditOpenSecureChannelEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ClientCertificate](#ClientCertificate)|[ByteString](../../../Part3/DataTypes/ByteString/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ClientCertificateThumbprint](#ClientCertificateThumbprint)|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[RequestType](#RequestType)|[SecurityTokenRequestType](../../../Part4/DataTypes/SecurityTokenRequestType/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[SecurityPolicyUri](#SecurityPolicyUri)|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[SecurityMode](#SecurityMode)|[MessageSecurityMode](../../../Part4/DataTypes/MessageSecurityMode/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[RequestedLifetime](#RequestedLifetime)|[Duration](../../../Part3/DataTypes/Duration/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


