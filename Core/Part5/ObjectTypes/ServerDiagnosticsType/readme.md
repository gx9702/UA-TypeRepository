<!-- objecttype -->
## ServerDiagnosticsType
The representation of the ServerDiagnosticsType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|ServerDiagnosticsType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[BaseObjectType](../../../Part5/ObjectTypes/BaseObjectType/readme.md)|

The references from the ServerDiagnosticsType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|ServerDiagnosticsSummary||[ServerDiagnosticsSummaryType](../../Part5/VariableTypes/ServerDiagnosticsSummaryType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|SamplingIntervalDiagnosticsArray||[SamplingIntervalDiagnosticsArrayType](../../Part5/VariableTypes/SamplingIntervalDiagnosticsArrayType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|SubscriptionDiagnosticsArray||[SubscriptionDiagnosticsArrayType](../../Part5/VariableTypes/SubscriptionDiagnosticsArrayType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|SessionsDiagnosticsSummary||[SessionsDiagnosticsSummaryType](../../Part5/ObjectTypes/SessionsDiagnosticsSummaryType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|EnabledFlag||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

