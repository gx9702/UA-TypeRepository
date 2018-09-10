<!-- objecttype -->
## SessionSecurityDiagnosticsType
  
The representation of the SessionSecurityDiagnosticsType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|SessionSecurityDiagnosticsType|
|NodeClass|VariableType|
|IsAbtract|False|
|BaseType|[BaseDataVariableType](../../../Part5/VariableTypes/BaseDataVariableType/readme.md)|

The references from the SessionSecurityDiagnosticsType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[SessionId](#SessionId)|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)|[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[ClientUserIdOfSession](#ClientUserIdOfSession)|[String](../../../Part3/DataTypes/String/readme.md)|[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[ClientUserIdHistory](#ClientUserIdHistory)|[String](../../../Part3/DataTypes/String/readme.md)[]|[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[AuthenticationMechanism](#AuthenticationMechanism)|[String](../../../Part3/DataTypes/String/readme.md)|[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[Encoding](#Encoding)|[String](../../../Part3/DataTypes/String/readme.md)|[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[TransportProtocol](#TransportProtocol)|[String](../../../Part3/DataTypes/String/readme.md)|[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[SecurityMode](#SecurityMode)|[MessageSecurityMode](../../../Part4/DataTypes/MessageSecurityMode/readme.md)|[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[SecurityPolicyUri](#SecurityPolicyUri)|[String](../../../Part3/DataTypes/String/readme.md)|[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[ClientCertificate](#ClientCertificate)|[ByteString](../../../Part3/DataTypes/ByteString/readme.md)|[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


