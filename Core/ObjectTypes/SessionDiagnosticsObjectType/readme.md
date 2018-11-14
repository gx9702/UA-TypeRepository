<!-- objecttype -->
## SessionDiagnosticsObjectType
A container for session level diagnostics information.  
<!-- end of text -->
The representation of the SessionDiagnosticsObjectType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2029|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|SessionDiagnosticsObjectType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[BaseObjectType](../../ObjectTypes/BaseObjectType/readme.md)|
|Categories||

The references from the SessionDiagnosticsObjectType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[SessionDiagnostics](#SessionDiagnostics)|[SessionDiagnosticsDataType](../../DataTypes/SessionDiagnosticsDataType/readme.md)|[SessionDiagnosticsVariableType](../../VariableTypes/SessionDiagnosticsVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[SessionSecurityDiagnostics](#SessionSecurityDiagnostics)|[SessionSecurityDiagnosticsDataType](../../DataTypes/SessionSecurityDiagnosticsDataType/readme.md)|[SessionSecurityDiagnosticsType](../../VariableTypes/SessionSecurityDiagnosticsType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[SubscriptionDiagnosticsArray](#SubscriptionDiagnosticsArray)|[SubscriptionDiagnosticsDataType](../../DataTypes/SubscriptionDiagnosticsDataType/readme.md)[]|[SubscriptionDiagnosticsArrayType](../../VariableTypes/SubscriptionDiagnosticsArrayType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


