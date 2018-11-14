<!-- objecttype -->
## UadpWriterGroupMessageType
  
<!-- end of text -->
The representation of the UadpWriterGroupMessageType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=21105|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|UadpWriterGroupMessageType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[WriterGroupMessageType](../../ObjectTypes/WriterGroupMessageType/readme.md)|
|Categories||

The references from the UadpWriterGroupMessageType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[GroupVersion](#GroupVersion)|[VersionTime](../../DataTypes/VersionTime/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[DataSetOrdering](#DataSetOrdering)|[DataSetOrderingType](../../DataTypes/DataSetOrderingType/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[NetworkMessageContentMask](#NetworkMessageContentMask)|[UadpNetworkMessageContentMask](../../DataTypes/UadpNetworkMessageContentMask/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[SamplingOffset](#SamplingOffset)|[Duration](../../DataTypes/Duration/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[PublishingOffset](#PublishingOffset)|[Duration](../../DataTypes/Duration/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


