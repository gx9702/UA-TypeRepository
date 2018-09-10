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
|[Organizes](../../../Part3/ReferenceTypes/Organizes/readme.md)|Object|&lt;DataSetFolderName&gt;||[DataSetFolderType](../../Part14/ObjectTypes/DataSetFolderType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|&lt;PublishedDataSetName&gt;||[PublishedDataSetType](../../Part14/ObjectTypes/PublishedDataSetType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|AddPublishedDataItems|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|AddPublishedEvents|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|AddPublishedDataItemsTemplate|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|AddPublishedEventsTemplate|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|RemovePublishedDataSet|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|AddDataSetFolder|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|RemoveDataSetFolder|||[Optional](../../Objects/Optional/readme.md)|

