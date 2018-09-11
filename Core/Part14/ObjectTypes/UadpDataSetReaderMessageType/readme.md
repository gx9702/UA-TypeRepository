<!-- objecttype -->
## UadpDataSetReaderMessageType
This ObjectType represents UADP message mapping specific parameters for a DataSetReader. The UadpDataSetWriterMessageType is formally defined in Table 160.  
<!-- end of text -->
The representation of the UadpDataSetReaderMessageType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=21116|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|UadpDataSetReaderMessageType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[DataSetReaderMessageType](../../../Part14/ObjectTypes/DataSetReaderMessageType/readme.md)|
|Categories|Part14|

The references from the UadpDataSetReaderMessageType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[GroupVersion](#GroupVersion)|[VersionTime](../../../Part4/DataTypes/VersionTime/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[DataSetOrdering](#DataSetOrdering)|[DataSetOrderingType](../../../Part14/DataTypes/DataSetOrderingType/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[NetworkMessageNumber](#NetworkMessageNumber)|[UInt16](../../../Part3/DataTypes/UInt16/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[DataSetOffset](#DataSetOffset)|[UInt16](../../../Part3/DataTypes/UInt16/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[DataSetClassId](#DataSetClassId)|[Guid](../../../Part3/DataTypes/Guid/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[NetworkMessageContentMask](#NetworkMessageContentMask)|[UadpNetworkMessageContentMask](../../../Part14/DataTypes/UadpNetworkMessageContentMask/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[DataSetMessageContentMask](#DataSetMessageContentMask)|[UadpDataSetMessageContentMask](../../../Part14/DataTypes/UadpDataSetMessageContentMask/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[PublishingInterval](#PublishingInterval)|[Duration](../../../Part3/DataTypes/Duration/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ProcessingOffset](#ProcessingOffset)|[Duration](../../../Part3/DataTypes/Duration/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ReceiveOffset](#ReceiveOffset)|[Duration](../../../Part3/DataTypes/Duration/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


