<!-- objecttype -->
## ServerDiagnosticsType
The diagnostics information for a server.  
<!-- end of text -->
The representation of the ServerDiagnosticsType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2020|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|ServerDiagnosticsType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[BaseObjectType](../../ObjectTypes/BaseObjectType/readme.md)|
|Categories||

The references from the ServerDiagnosticsType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[ServerDiagnosticsSummary](#ServerDiagnosticsSummary)|[ServerDiagnosticsSummaryDataType](../../DataTypes/ServerDiagnosticsSummaryDataType/readme.md)|[ServerDiagnosticsSummaryType](../../VariableTypes/ServerDiagnosticsSummaryType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[SamplingIntervalDiagnosticsArray](#SamplingIntervalDiagnosticsArray)|[SamplingIntervalDiagnosticsDataType](../../DataTypes/SamplingIntervalDiagnosticsDataType/readme.md)[]|[SamplingIntervalDiagnosticsArrayType](../../VariableTypes/SamplingIntervalDiagnosticsArrayType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[SubscriptionDiagnosticsArray](#SubscriptionDiagnosticsArray)|[SubscriptionDiagnosticsDataType](../../DataTypes/SubscriptionDiagnosticsDataType/readme.md)[]|[SubscriptionDiagnosticsArrayType](../../VariableTypes/SubscriptionDiagnosticsArrayType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[SessionsDiagnosticsSummary](#SessionsDiagnosticsSummary)||[SessionsDiagnosticsSummaryType](../../ObjectTypes/SessionsDiagnosticsSummaryType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[EnabledFlag](#EnabledFlag)|[Boolean](../../DataTypes/Boolean/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


