<!-- datatype -->
## ProgramDiagnosticDataType
  
<!-- end of description -->
The fields of the ProgramDiagnosticDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|ProgramDiagnosticDataType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;createSessionId|[NodeId](../../DataTypes/NodeId/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;createClientName|[String](../../DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;invocationCreationTime|[UtcTime](../../DataTypes/UtcTime/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;lastTransitionTime|[UtcTime](../../DataTypes/UtcTime/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;lastMethodCall|[String](../../DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;lastMethodSessionId|[NodeId](../../DataTypes/NodeId/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;lastMethodInputArguments|[Argument](../../DataTypes/Argument/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;lastMethodOutputArguments|[Argument](../../DataTypes/Argument/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;lastMethodCallTime|[UtcTime](../../DataTypes/UtcTime/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;lastMethodReturnStatus|[StatusResult](../../DataTypes/StatusResult/readme.md)||

The representation of the ProgramDiagnosticDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=894|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|ProgramDiagnosticDataType|
|IsAbstract|False|
|BaseType|[Structure](../../DataTypes/Structure/readme.md)|
|Categories||

