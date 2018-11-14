<!-- objecttype -->
## PubSubDiagnosticsType
  
<!-- end of text -->
The representation of the PubSubDiagnosticsType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=19677|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|PubSubDiagnosticsType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[BaseObjectType](../../ObjectTypes/BaseObjectType/readme.md)|
|Categories||

The references from the PubSubDiagnosticsType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[DiagnosticsLevel](#DiagnosticsLevel)|[DiagnosticsLevel](../../DataTypes/DiagnosticsLevel/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[TotalInformation](#TotalInformation)|[UInt32](../../DataTypes/UInt32/readme.md)|[PubSubDiagnosticsCounterType](../../VariableTypes/PubSubDiagnosticsCounterType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[TotalError](#TotalError)|[UInt32](../../DataTypes/UInt32/readme.md)|[PubSubDiagnosticsCounterType](../../VariableTypes/PubSubDiagnosticsCounterType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[Reset](#Reset)|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[SubError](#SubError)|[Boolean](../../DataTypes/Boolean/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[Counters](#Counters)||[BaseObjectType](../../ObjectTypes/BaseObjectType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[LiveValues](#LiveValues)||[BaseObjectType](../../ObjectTypes/BaseObjectType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[PubSubDiagnosticsRootType](#PubSubDiagnosticsRootType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[PubSubDiagnosticsConnectionType](#PubSubDiagnosticsConnectionType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[PubSubDiagnosticsWriterGroupType](#PubSubDiagnosticsWriterGroupType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[PubSubDiagnosticsReaderGroupType](#PubSubDiagnosticsReaderGroupType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[PubSubDiagnosticsDataSetWriterType](#PubSubDiagnosticsDataSetWriterType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[PubSubDiagnosticsDataSetReaderType](#PubSubDiagnosticsDataSetReaderType)||||

### <a name="Reset"></a>Reset
  
**Signature**
```
    Reset(    );
```

