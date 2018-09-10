<!-- objecttype -->
## PubSubDiagnosticsType
The representation of the PubSubDiagnosticsType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|PubSubDiagnosticsType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[BaseObjectType](../../../Part5/ObjectTypes/BaseObjectType/readme.md)|

The references from the PubSubDiagnosticsType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|DiagnosticsLevel||[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|TotalInformation||[PubSubDiagnosticsCounterType](../../Part14/VariableTypes/PubSubDiagnosticsCounterType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|TotalError||[PubSubDiagnosticsCounterType](../../Part14/VariableTypes/PubSubDiagnosticsCounterType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|Reset|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|SubError||[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|Counters||[BaseObjectType](../../Part5/ObjectTypes/BaseObjectType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|LiveValues||[BaseObjectType](../../Part5/ObjectTypes/BaseObjectType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|PubSubDiagnosticsRootType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|PubSubDiagnosticsConnectionType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|PubSubDiagnosticsWriterGroupType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|PubSubDiagnosticsReaderGroupType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|PubSubDiagnosticsDataSetWriterType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|PubSubDiagnosticsDataSetReaderType||||

