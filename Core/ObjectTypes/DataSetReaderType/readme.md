<!-- objecttype -->
## DataSetReaderType
  
<!-- end of text -->
The representation of the DataSetReaderType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15306|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|DataSetReaderType|
|NodeClass|ObjectType|
|IsAbstract|True|
|BaseType|[BaseObjectType](../../ObjectTypes/BaseObjectType/readme.md)|
|Categories||

The references from the DataSetReaderType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[PublisherId](#PublisherId)|[BaseDataType](../../DataTypes/BaseDataType/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[WriterGroupId](#WriterGroupId)|[UInt16](../../DataTypes/UInt16/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[DataSetWriterId](#DataSetWriterId)|[UInt16](../../DataTypes/UInt16/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[DataSetMetaData](#DataSetMetaData)|[DataSetMetaDataType](../../DataTypes/DataSetMetaDataType/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[DataSetFieldContentMask](#DataSetFieldContentMask)|[DataSetFieldContentMask](../../DataTypes/DataSetFieldContentMask/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[MessageReceiveTimeout](#MessageReceiveTimeout)|[Duration](../../DataTypes/Duration/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[KeyFrameCount](#KeyFrameCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[HeaderLayoutUri](#HeaderLayoutUri)|[String](../../DataTypes/String/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[SecurityMode](#SecurityMode)|[MessageSecurityMode](../../DataTypes/MessageSecurityMode/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[SecurityGroupId](#SecurityGroupId)|[String](../../DataTypes/String/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[SecurityKeyServices](#SecurityKeyServices)|[EndpointDescription](../../DataTypes/EndpointDescription/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[DataSetReaderProperties](#DataSetReaderProperties)|[KeyValuePair](../../DataTypes/KeyValuePair/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[TransportSettings](#TransportSettings)||[DataSetReaderTransportType](../../ObjectTypes/DataSetReaderTransportType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[MessageSettings](#MessageSettings)||[DataSetReaderMessageType](../../ObjectTypes/DataSetReaderMessageType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[Status](#Status)||[PubSubStatusType](../../ObjectTypes/PubSubStatusType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[Diagnostics](#Diagnostics)||[PubSubDiagnosticsDataSetReaderType](../../ObjectTypes/PubSubDiagnosticsDataSetReaderType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[SubscribedDataSet](#SubscribedDataSet)||[SubscribedDataSetType](../../ObjectTypes/SubscribedDataSetType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[CreateTargetVariables](#CreateTargetVariables)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[CreateDataSetMirror](#CreateDataSetMirror)|||[Optional](../../Objects/Optional/readme.md)|

### <a name="CreateTargetVariables"></a>CreateTargetVariables
  
**Signature**
```
    CreateTargetVariables(
        [in]  ConfigurationVersionDataType ConfigurationVersion
        [in]  FieldTargetDataType TargetVariablesToAdd
        [in]  StatusCode AddResults
    );
```

|Argument|Description|
|---|---|
|ConfigurationVersion||
|TargetVariablesToAdd||
|AddResults||

### <a name="CreateDataSetMirror"></a>CreateDataSetMirror
  
**Signature**
```
    CreateDataSetMirror(
        [in]  String ParentNodeName
        [in]  RolePermissionType RolePermissions
        [in]  NodeId ParentNodeId
    );
```

|Argument|Description|
|---|---|
|ParentNodeName||
|RolePermissions||
|ParentNodeId||


