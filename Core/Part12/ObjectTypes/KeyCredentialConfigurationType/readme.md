<!-- objecttype -->
## KeyCredentialConfigurationType
The representation of the KeyCredentialConfigurationType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|KeyCredentialConfigurationType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[BaseObjectType](../../../Part5/ObjectTypes/BaseObjectType/readme.md)|

The references from the KeyCredentialConfigurationType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|ResourceUri||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|ProfileUri||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|EndpointUrls||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|ServiceStatus||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|GetEncryptingKey|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|UpdateCredential|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|DeleteCredential|||[Optional](../../Objects/Optional/readme.md)|

