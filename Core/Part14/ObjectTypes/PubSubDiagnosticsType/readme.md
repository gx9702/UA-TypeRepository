<!-- objecttype -->
## PubSubDiagnosticsType
The PubSubDiagnosticsType is the base type for the diagnostics objects and is formally defined in Table 134.  
<!-- end of text -->
The representation of the PubSubDiagnosticsType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=19677|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|PubSubDiagnosticsType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[BaseObjectType](../../../Part5/ObjectTypes/BaseObjectType/readme.md)|
|Categories|Part14|

The references from the PubSubDiagnosticsType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[DiagnosticsLevel](#DiagnosticsLevel)|[DiagnosticsLevel](../../../Part14/DataTypes/DiagnosticsLevel/readme.md)|[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[TotalInformation](#TotalInformation)|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)|[PubSubDiagnosticsCounterType](../../Part14/VariableTypes/PubSubDiagnosticsCounterType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[TotalError](#TotalError)|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)|[PubSubDiagnosticsCounterType](../../Part14/VariableTypes/PubSubDiagnosticsCounterType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[Reset](#Reset)|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[SubError](#SubError)|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)|[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Counters](#Counters)||[BaseObjectType](../../Part5/ObjectTypes/BaseObjectType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[LiveValues](#LiveValues)||[BaseObjectType](../../Part5/ObjectTypes/BaseObjectType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[PubSubDiagnosticsRootType](#PubSubDiagnosticsRootType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[PubSubDiagnosticsConnectionType](#PubSubDiagnosticsConnectionType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[PubSubDiagnosticsWriterGroupType](#PubSubDiagnosticsWriterGroupType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[PubSubDiagnosticsReaderGroupType](#PubSubDiagnosticsReaderGroupType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[PubSubDiagnosticsDataSetWriterType](#PubSubDiagnosticsDataSetWriterType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[PubSubDiagnosticsDataSetReaderType](#PubSubDiagnosticsDataSetReaderType)||||

### <a name="Reset"></a>Reset
  
**Signature**
```
    Reset(    );
```

