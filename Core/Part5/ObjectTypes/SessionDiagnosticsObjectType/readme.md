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
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|SessionDiagnostics|[SessionDiagnosticsDataType](../../../Part5/DataTypes/SessionDiagnosticsDataType/readme.md)|[SessionDiagnosticsVariableType](../../Part5/VariableTypes/SessionDiagnosticsVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|SessionSecurityDiagnostics|[SessionSecurityDiagnosticsDataType](../../../Part5/DataTypes/SessionSecurityDiagnosticsDataType/readme.md)|[SessionSecurityDiagnosticsType](../../Part5/VariableTypes/SessionSecurityDiagnosticsType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|SubscriptionDiagnosticsArray|[SubscriptionDiagnosticsDataType](../../../Part5/DataTypes/SubscriptionDiagnosticsDataType/readme.md)[]|[SubscriptionDiagnosticsArrayType](../../Part5/VariableTypes/SubscriptionDiagnosticsArrayType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

