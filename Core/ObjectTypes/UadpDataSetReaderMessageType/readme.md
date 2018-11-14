<!-- objecttype -->
## UadpDataSetReaderMessageType
  
<!-- end of text -->
The representation of the UadpDataSetReaderMessageType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=21116|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|UadpDataSetReaderMessageType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[DataSetReaderMessageType](../../ObjectTypes/DataSetReaderMessageType/readme.md)|
|Categories||

The references from the UadpDataSetReaderMessageType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[GroupVersion](#GroupVersion)|[VersionTime](../../DataTypes/VersionTime/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[DataSetOrdering](#DataSetOrdering)|[DataSetOrderingType](../../DataTypes/DataSetOrderingType/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[NetworkMessageNumber](#NetworkMessageNumber)|[UInt16](../../DataTypes/UInt16/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[DataSetOffset](#DataSetOffset)|[UInt16](../../DataTypes/UInt16/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[DataSetClassId](#DataSetClassId)|[Guid](../../DataTypes/Guid/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[NetworkMessageContentMask](#NetworkMessageContentMask)|[UadpNetworkMessageContentMask](../../DataTypes/UadpNetworkMessageContentMask/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[DataSetMessageContentMask](#DataSetMessageContentMask)|[UadpDataSetMessageContentMask](../../DataTypes/UadpDataSetMessageContentMask/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[PublishingInterval](#PublishingInterval)|[Duration](../../DataTypes/Duration/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ProcessingOffset](#ProcessingOffset)|[Duration](../../DataTypes/Duration/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ReceiveOffset](#ReceiveOffset)|[Duration](../../DataTypes/Duration/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


