<!-- objecttype -->
## PubSubDiagnosticsCounterType
The PubSubDiagnosticsCounterType is formally defined in Table 137.  
<!-- end of text -->
The representation of the PubSubDiagnosticsCounterType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=19725|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|PubSubDiagnosticsCounterType|
|NodeClass|VariableType|
|DataType|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)|
|ValueRank|-1|
|IsAbstract|False|
|BaseType|[BaseDataVariableType](../../../Part5/VariableTypes/BaseDataVariableType/readme.md)|
|Categories|Part14|

The references from the PubSubDiagnosticsCounterType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[Active](#Active)|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[Classification](#Classification)|[PubSubDiagnosticsCounterClassification](../../../Part14/DataTypes/PubSubDiagnosticsCounterClassification/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[DiagnosticsLevel](#DiagnosticsLevel)|[DiagnosticsLevel](../../../Part14/DataTypes/DiagnosticsLevel/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[TimeFirstChange](#TimeFirstChange)|[DateTime](../../../Part3/DataTypes/DateTime/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


