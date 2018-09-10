<!-- objecttype -->
## DataSetFolderType
  
The representation of the DataSetFolderType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|DataSetFolderType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[FolderType](../../../Part5/ObjectTypes/FolderType/readme.md)|

The references from the DataSetFolderType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[Organizes](../../../Part3/ReferenceTypes/Organizes/readme.md)|Object|[&lt;DataSetFolderName&gt;](#&lt;DataSetFolderName&gt;)||[DataSetFolderType](../../Part14/ObjectTypes/DataSetFolderType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[&lt;PublishedDataSetName&gt;](#&lt;PublishedDataSetName&gt;)||[PublishedDataSetType](../../Part14/ObjectTypes/PublishedDataSetType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[AddPublishedDataItems](#AddPublishedDataItems)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[AddPublishedEvents](#AddPublishedEvents)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[AddPublishedDataItemsTemplate](#AddPublishedDataItemsTemplate)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[AddPublishedEventsTemplate](#AddPublishedEventsTemplate)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[RemovePublishedDataSet](#RemovePublishedDataSet)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[AddDataSetFolder](#AddDataSetFolder)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[RemoveDataSetFolder](#RemoveDataSetFolder)|||[Optional](../../Objects/Optional/readme.md)|

### <a name="AddPublishedDataItems"></a>AddPublishedDataItems
  
**Signature**
```
    AddPublishedDataItems(
        [in]  String Name
        [in]  String FieldNameAliases
        [in]  DataSetFieldFlags FieldFlags
        [in]  PublishedVariableDataType VariablesToAdd
        [in]  NodeId DataSetNodeId
        [in]  ConfigurationVersionDataType ConfigurationVersion
        [in]  StatusCode AddResults
    );
```

|Argument|Description|
|---|---|
|Name||
|FieldNameAliases||
|FieldFlags||
|VariablesToAdd||
|DataSetNodeId||
|ConfigurationVersion||
|AddResults||

### <a name="AddPublishedEvents"></a>AddPublishedEvents
  
**Signature**
```
    AddPublishedEvents(
        [in]  String Name
        [in]  NodeId EventNotifier
        [in]  String FieldNameAliases
        [in]  DataSetFieldFlags FieldFlags
        [in]  SimpleAttributeOperand SelectedFields
        [in]  ContentFilter Filter
        [in]  ConfigurationVersionDataType ConfigurationVersion
        [in]  NodeId DataSetNodeId
    );
```

|Argument|Description|
|---|---|
|Name||
|EventNotifier||
|FieldNameAliases||
|FieldFlags||
|SelectedFields||
|Filter||
|ConfigurationVersion||
|DataSetNodeId||

### <a name="AddPublishedDataItemsTemplate"></a>AddPublishedDataItemsTemplate
  
**Signature**
```
    AddPublishedDataItemsTemplate(
        [in]  String Name
        [in]  DataSetMetaDataType DataSetMetaData
        [in]  PublishedVariableDataType VariablesToAdd
        [in]  NodeId DataSetNodeId
        [in]  StatusCode AddResults
    );
```

|Argument|Description|
|---|---|
|Name||
|DataSetMetaData||
|VariablesToAdd||
|DataSetNodeId||
|AddResults||

### <a name="AddPublishedEventsTemplate"></a>AddPublishedEventsTemplate
  
**Signature**
```
    AddPublishedEventsTemplate(
        [in]  String Name
        [in]  DataSetMetaDataType DataSetMetaData
        [in]  NodeId EventNotifier
        [in]  SimpleAttributeOperand SelectedFields
        [in]  ContentFilter Filter
        [in]  NodeId DataSetNodeId
    );
```

|Argument|Description|
|---|---|
|Name||
|DataSetMetaData||
|EventNotifier||
|SelectedFields||
|Filter||
|DataSetNodeId||

### <a name="RemovePublishedDataSet"></a>RemovePublishedDataSet
  
**Signature**
```
    RemovePublishedDataSet(
        [in]  NodeId DataSetNodeId
    );
```

|Argument|Description|
|---|---|
|DataSetNodeId||

### <a name="AddDataSetFolder"></a>AddDataSetFolder
  
**Signature**
```
    AddDataSetFolder(
        [in]  String Name
        [in]  NodeId DataSetFolderNodeId
    );
```

|Argument|Description|
|---|---|
|Name||
|DataSetFolderNodeId||

### <a name="RemoveDataSetFolder"></a>RemoveDataSetFolder
  
**Signature**
```
    RemoveDataSetFolder(
        [in]  NodeId DataSetFolderNodeId
    );
```

|Argument|Description|
|---|---|
|DataSetFolderNodeId||


