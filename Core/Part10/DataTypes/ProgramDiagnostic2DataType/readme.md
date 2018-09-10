<!-- datatype -->
## ProgramDiagnostic2DataType
<!-- end of description -->
The fields of the ProgramDiagnostic2DataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|ProgramDiagnostic2DataType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;createSessionId|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;createClientName|[String](../../../Part3/DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;invocationCreationTime|[UtcTime](../../../Part3/DataTypes/UtcTime/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;lastTransitionTime|[UtcTime](../../../Part3/DataTypes/UtcTime/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;lastMethodCall|[String](../../../Part3/DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;lastMethodSessionId|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;lastMethodInputArguments|[Argument](../../../Part3/DataTypes/Argument/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;lastMethodOutputArguments|[Argument](../../../Part3/DataTypes/Argument/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;lastMethodInputValues|[BaseDataType](../../../Part3/DataTypes/BaseDataType/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;lastMethodOutputValues|[BaseDataType](../../../Part3/DataTypes/BaseDataType/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;lastMethodCallTime|[UtcTime](../../../Part3/DataTypes/UtcTime/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;lastMethodReturnStatus|[StatusResult](../../../Part5/DataTypes/StatusResult/readme.md)||

The representation of the ProgramDiagnostic2DataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|ProgramDiagnostic2DataType|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

