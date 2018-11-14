<!-- objecttype -->
## ProgramDiagnosticType
  
<!-- end of text -->
The representation of the ProgramDiagnosticType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2380|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|ProgramDiagnosticType|
|NodeClass|VariableType|
|DataType|[ProgramDiagnosticDataType](../../DataTypes/ProgramDiagnosticDataType/readme.md)|
|ValueRank|-1|
|IsAbstract|False|
|BaseType|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|
|Categories||

The references from the ProgramDiagnosticType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[CreateSessionId](#CreateSessionId)|[NodeId](../../DataTypes/NodeId/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[CreateClientName](#CreateClientName)|[String](../../DataTypes/String/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[InvocationCreationTime](#InvocationCreationTime)|[UtcTime](../../DataTypes/UtcTime/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[LastTransitionTime](#LastTransitionTime)|[UtcTime](../../DataTypes/UtcTime/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[LastMethodCall](#LastMethodCall)|[String](../../DataTypes/String/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[LastMethodSessionId](#LastMethodSessionId)|[NodeId](../../DataTypes/NodeId/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[LastMethodInputArguments](#LastMethodInputArguments)|[BaseDataType](../../DataTypes/BaseDataType/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[LastMethodOutputArguments](#LastMethodOutputArguments)|[BaseDataType](../../DataTypes/BaseDataType/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[LastMethodCallTime](#LastMethodCallTime)|[UtcTime](../../DataTypes/UtcTime/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[LastMethodReturnStatus](#LastMethodReturnStatus)|[StatusCode](../../DataTypes/StatusCode/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


