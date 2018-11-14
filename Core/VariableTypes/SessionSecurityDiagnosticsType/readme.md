<!-- objecttype -->
## SessionSecurityDiagnosticsType
  
<!-- end of text -->
The representation of the SessionSecurityDiagnosticsType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2244|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|SessionSecurityDiagnosticsType|
|NodeClass|VariableType|
|DataType|[SessionSecurityDiagnosticsDataType](../../DataTypes/SessionSecurityDiagnosticsDataType/readme.md)|
|ValueRank|-1|
|IsAbstract|False|
|BaseType|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|
|Categories||

The references from the SessionSecurityDiagnosticsType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[SessionId](#SessionId)|[NodeId](../../DataTypes/NodeId/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[ClientUserIdOfSession](#ClientUserIdOfSession)|[String](../../DataTypes/String/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[ClientUserIdHistory](#ClientUserIdHistory)|[String](../../DataTypes/String/readme.md)[]|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[AuthenticationMechanism](#AuthenticationMechanism)|[String](../../DataTypes/String/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[Encoding](#Encoding)|[String](../../DataTypes/String/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[TransportProtocol](#TransportProtocol)|[String](../../DataTypes/String/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[SecurityMode](#SecurityMode)|[MessageSecurityMode](../../DataTypes/MessageSecurityMode/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[SecurityPolicyUri](#SecurityPolicyUri)|[String](../../DataTypes/String/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[ClientCertificate](#ClientCertificate)|[ByteString](../../DataTypes/ByteString/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


