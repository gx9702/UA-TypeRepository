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
|BaseType|[BaseObjectType](../../../Part5/ObjectTypes/BaseObjectType/readme.md)|
|Categories|Part5|

The references from the SessionDiagnosticsObjectType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[SessionDiagnostics](#SessionDiagnostics)|[SessionDiagnosticsDataType](../../../Part5/DataTypes/SessionDiagnosticsDataType/readme.md)|[SessionDiagnosticsVariableType](../../Part5/VariableTypes/SessionDiagnosticsVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[SessionSecurityDiagnostics](#SessionSecurityDiagnostics)|[SessionSecurityDiagnosticsDataType](../../../Part5/DataTypes/SessionSecurityDiagnosticsDataType/readme.md)|[SessionSecurityDiagnosticsType](../../Part5/VariableTypes/SessionSecurityDiagnosticsType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[SubscriptionDiagnosticsArray](#SubscriptionDiagnosticsArray)|[SubscriptionDiagnosticsDataType](../../../Part5/DataTypes/SubscriptionDiagnosticsDataType/readme.md)[]|[SubscriptionDiagnosticsArrayType](../../Part5/VariableTypes/SubscriptionDiagnosticsArrayType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


