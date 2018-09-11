<!-- objecttype -->
## JsonDataSetReaderMessageType
This ObjectType represents UADP message mapping specific parameters for a DataSetReader. The JsonDataSetReaderMessageType is formally defined in Table 163.  
<!-- end of text -->
The representation of the JsonDataSetReaderMessageType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=21130|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|JsonDataSetReaderMessageType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[DataSetReaderMessageType](../../../Part14/ObjectTypes/DataSetReaderMessageType/readme.md)|
|Categories|Part14|

The references from the JsonDataSetReaderMessageType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[NetworkMessageContentMask](#NetworkMessageContentMask)|[JsonNetworkMessageContentMask](../../../Part14/DataTypes/JsonNetworkMessageContentMask/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[DataSetMessageContentMask](#DataSetMessageContentMask)|[JsonDataSetMessageContentMask](../../../Part14/DataTypes/JsonDataSetMessageContentMask/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


