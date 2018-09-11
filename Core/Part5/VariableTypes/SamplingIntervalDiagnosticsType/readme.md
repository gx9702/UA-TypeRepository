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
|DataType|[SamplingIntervalDiagnosticsDataType](../../../Part5/DataTypes/SamplingIntervalDiagnosticsDataType/readme.md)|
|ValueRank|-1|
|IsAbstract|False|
|BaseType|[BaseDataVariableType](../../../Part5/VariableTypes/BaseDataVariableType/readme.md)|
|Categories|Part5|

The references from the SamplingIntervalDiagnosticsType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[SamplingInterval](#SamplingInterval)|[Duration](../../../Part3/DataTypes/Duration/readme.md)|[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[SampledMonitoredItemsCount](#SampledMonitoredItemsCount)|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[MaxSampledMonitoredItemsCount](#MaxSampledMonitoredItemsCount)|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[DisabledMonitoredItemsSamplingCount](#DisabledMonitoredItemsSamplingCount)|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


