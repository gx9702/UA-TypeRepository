<!-- objecttype -->
## SamplingIntervalDiagnosticsType
  
<!-- end of text -->
The representation of the SamplingIntervalDiagnosticsType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2165|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|SamplingIntervalDiagnosticsType|
|NodeClass|VariableType|
|DataType|[SamplingIntervalDiagnosticsDataType](../../DataTypes/SamplingIntervalDiagnosticsDataType/readme.md)|
|ValueRank|-1|
|IsAbstract|False|
|BaseType|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|
|Categories||

The references from the SamplingIntervalDiagnosticsType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[SamplingInterval](#SamplingInterval)|[Duration](../../DataTypes/Duration/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[SampledMonitoredItemsCount](#SampledMonitoredItemsCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[MaxSampledMonitoredItemsCount](#MaxSampledMonitoredItemsCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[DisabledMonitoredItemsSamplingCount](#DisabledMonitoredItemsSamplingCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


