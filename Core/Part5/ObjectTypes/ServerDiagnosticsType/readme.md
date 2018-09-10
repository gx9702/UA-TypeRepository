<!-- objecttype -->
## ServerDiagnosticsType
The diagnostics information for a server.
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
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[ServerDiagnosticsSummary](#ServerDiagnosticsSummary)|[ServerDiagnosticsSummaryDataType](../../../Part5/DataTypes/ServerDiagnosticsSummaryDataType/readme.md)|[ServerDiagnosticsSummaryType](../../Part5/VariableTypes/ServerDiagnosticsSummaryType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[SamplingIntervalDiagnosticsArray](#SamplingIntervalDiagnosticsArray)|[SamplingIntervalDiagnosticsDataType](../../../Part5/DataTypes/SamplingIntervalDiagnosticsDataType/readme.md)[]|[SamplingIntervalDiagnosticsArrayType](../../Part5/VariableTypes/SamplingIntervalDiagnosticsArrayType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[SubscriptionDiagnosticsArray](#SubscriptionDiagnosticsArray)|[SubscriptionDiagnosticsDataType](../../../Part5/DataTypes/SubscriptionDiagnosticsDataType/readme.md)[]|[SubscriptionDiagnosticsArrayType](../../Part5/VariableTypes/SubscriptionDiagnosticsArrayType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[SessionsDiagnosticsSummary](#SessionsDiagnosticsSummary)||[SessionsDiagnosticsSummaryType](../../Part5/ObjectTypes/SessionsDiagnosticsSummaryType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[EnabledFlag](#EnabledFlag)|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


