<!-- objecttype -->
## SessionsDiagnosticsSummaryType
Provides a summary of session level diagnostics.  
<!-- end of text -->
The representation of the SessionsDiagnosticsSummaryType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2026|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|SessionsDiagnosticsSummaryType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[BaseObjectType](../../ObjectTypes/BaseObjectType/readme.md)|
|Categories||

The references from the SessionsDiagnosticsSummaryType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[SessionDiagnosticsArray](#SessionDiagnosticsArray)|[SessionDiagnosticsDataType](../../DataTypes/SessionDiagnosticsDataType/readme.md)[]|[SessionDiagnosticsArrayType](../../VariableTypes/SessionDiagnosticsArrayType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[SessionSecurityDiagnosticsArray](#SessionSecurityDiagnosticsArray)|[SessionSecurityDiagnosticsDataType](../../DataTypes/SessionSecurityDiagnosticsDataType/readme.md)[]|[SessionSecurityDiagnosticsArrayType](../../VariableTypes/SessionSecurityDiagnosticsArrayType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[&lt;ClientName&gt;](#&lt;ClientName&gt;)||[SessionDiagnosticsObjectType](../../ObjectTypes/SessionDiagnosticsObjectType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|


