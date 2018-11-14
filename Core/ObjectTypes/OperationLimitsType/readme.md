<!-- objecttype -->
## OperationLimitsType
Identifies the operation limits imposed by the server.  
<!-- end of text -->
The representation of the OperationLimitsType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=11564|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|OperationLimitsType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[FolderType](../../ObjectTypes/FolderType/readme.md)|
|Categories||

The references from the OperationLimitsType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[MaxNodesPerRead](#MaxNodesPerRead)|[UInt32](../../DataTypes/UInt32/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[MaxNodesPerHistoryReadData](#MaxNodesPerHistoryReadData)|[UInt32](../../DataTypes/UInt32/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[MaxNodesPerHistoryReadEvents](#MaxNodesPerHistoryReadEvents)|[UInt32](../../DataTypes/UInt32/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[MaxNodesPerWrite](#MaxNodesPerWrite)|[UInt32](../../DataTypes/UInt32/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[MaxNodesPerHistoryUpdateData](#MaxNodesPerHistoryUpdateData)|[UInt32](../../DataTypes/UInt32/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[MaxNodesPerHistoryUpdateEvents](#MaxNodesPerHistoryUpdateEvents)|[UInt32](../../DataTypes/UInt32/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[MaxNodesPerMethodCall](#MaxNodesPerMethodCall)|[UInt32](../../DataTypes/UInt32/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[MaxNodesPerBrowse](#MaxNodesPerBrowse)|[UInt32](../../DataTypes/UInt32/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[MaxNodesPerRegisterNodes](#MaxNodesPerRegisterNodes)|[UInt32](../../DataTypes/UInt32/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[MaxNodesPerTranslateBrowsePathsToNodeIds](#MaxNodesPerTranslateBrowsePathsToNodeIds)|[UInt32](../../DataTypes/UInt32/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[MaxNodesPerNodeManagement](#MaxNodesPerNodeManagement)|[UInt32](../../DataTypes/UInt32/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[MaxMonitoredItemsPerCall](#MaxMonitoredItemsPerCall)|[UInt32](../../DataTypes/UInt32/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|


