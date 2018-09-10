<!-- objecttype -->
## AuditCreateSessionEventType
The representation of the AuditCreateSessionEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|AuditCreateSessionEventType|
|NodeClass|ObjectType|
|IsAbtract|True|
|BaseType|[AuditSessionEventType](../../../Part5/ObjectTypes/AuditSessionEventType/readme.md)|

The references from the AuditCreateSessionEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|SecureChannelId||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|ClientCertificate||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|ClientCertificateThumbprint||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|RevisedSessionTimeout||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|AuditUrlMismatchEventType||||

