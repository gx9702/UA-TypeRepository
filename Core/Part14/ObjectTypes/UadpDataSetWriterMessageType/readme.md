<!-- objecttype -->
## UadpDataSetWriterMessageType
This ObjectType represents UADP message mapping specific parameters for a DataSetWriter. The UadpDataSetWriterMessageType is formally defined in Table 159.  
<!-- end of text -->
The representation of the UadpDataSetWriterMessageType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=21111|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|UadpDataSetWriterMessageType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[DataSetWriterMessageType](../../../Part14/ObjectTypes/DataSetWriterMessageType/readme.md)|
|Categories|Part14|

The references from the UadpDataSetWriterMessageType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[DataSetMessageContentMask](#DataSetMessageContentMask)|[UadpDataSetMessageContentMask](../../../Part14/DataTypes/UadpDataSetMessageContentMask/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ConfiguredSize](#ConfiguredSize)|[UInt16](../../../Part3/DataTypes/UInt16/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[NetworkMessageNumber](#NetworkMessageNumber)|[UInt16](../../../Part3/DataTypes/UInt16/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[DataSetOffset](#DataSetOffset)|[UInt16](../../../Part3/DataTypes/UInt16/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


