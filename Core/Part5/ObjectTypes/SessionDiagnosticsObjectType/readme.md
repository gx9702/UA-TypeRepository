<!-- objecttype -->
## SessionDiagnosticsObjectType
The representation of the SessionDiagnosticsObjectType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|SessionDiagnosticsObjectType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[BaseObjectType](../../../Part5/ObjectTypes/BaseObjectType/readme.md)|

The references from the SessionDiagnosticsObjectType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|SessionDiagnostics||[SessionDiagnosticsVariableType](../../Part5/VariableTypes/SessionDiagnosticsVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|SessionSecurityDiagnostics||[SessionSecurityDiagnosticsType](../../Part5/VariableTypes/SessionSecurityDiagnosticsType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|SubscriptionDiagnosticsArray||[SubscriptionDiagnosticsArrayType](../../Part5/VariableTypes/SubscriptionDiagnosticsArrayType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

