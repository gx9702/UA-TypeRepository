<!-- objecttype -->
## UadpWriterGroupMessageType
  
The representation of the UadpWriterGroupMessageType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|UadpWriterGroupMessageType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[WriterGroupMessageType](../../../Part14/ObjectTypes/WriterGroupMessageType/readme.md)|

The references from the UadpWriterGroupMessageType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[GroupVersion](#GroupVersion)|[VersionTime](../../../Part4/DataTypes/VersionTime/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[DataSetOrdering](#DataSetOrdering)|[DataSetOrderingType](../../../Part14/DataTypes/DataSetOrderingType/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[NetworkMessageContentMask](#NetworkMessageContentMask)|[UadpNetworkMessageContentMask](../../../Part14/DataTypes/UadpNetworkMessageContentMask/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[SamplingOffset](#SamplingOffset)|[Duration](../../../Part3/DataTypes/Duration/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[PublishingOffset](#PublishingOffset)|[Duration](../../../Part3/DataTypes/Duration/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

