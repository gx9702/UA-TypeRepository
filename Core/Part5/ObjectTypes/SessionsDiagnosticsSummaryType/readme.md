<!-- objecttype -->
## SessionsDiagnosticsSummaryType
The representation of the SessionsDiagnosticsSummaryType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|SessionsDiagnosticsSummaryType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[BaseObjectType](../../../Part5/ObjectTypes/BaseObjectType/readme.md)|

The references from the SessionsDiagnosticsSummaryType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|SessionDiagnosticsArray|[SessionDiagnosticsDataType](../../../Part5/DataTypes/SessionDiagnosticsDataType/readme.md)[]|[SessionDiagnosticsArrayType](../../Part5/VariableTypes/SessionDiagnosticsArrayType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|SessionSecurityDiagnosticsArray|[SessionSecurityDiagnosticsDataType](../../../Part5/DataTypes/SessionSecurityDiagnosticsDataType/readme.md)[]|[SessionSecurityDiagnosticsArrayType](../../Part5/VariableTypes/SessionSecurityDiagnosticsArrayType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|&lt;ClientName&gt;||[SessionDiagnosticsObjectType](../../Part5/ObjectTypes/SessionDiagnosticsObjectType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|

