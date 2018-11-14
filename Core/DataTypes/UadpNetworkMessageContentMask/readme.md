<!-- datatype -->
## UadpNetworkMessageContentMask
  
<!-- end of description -->
The fields of the UadpNetworkMessageContentMask DataType are defined in the following table:  

|Name|Bit No.| Description|
|---|---|---|
|PublisherId|0||
|GroupHeader|1||
|WriterGroupId|2||
|GroupVersion|3||
|NetworkMessageNumber|4||
|SequenceNumber|5||
|PayloadHeader|6||
|Timestamp|7||
|Picoseconds|8||
|DataSetClassId|9||
|PromotedFields|10||

The representation of the UadpNetworkMessageContentMask DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15642|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|UadpNetworkMessageContentMask|
|IsAbstract|False|
|BaseType|[UInt32](../../DataTypes/UInt32/readme.md)|
|Categories||

The references from the UadpNetworkMessageContentMask DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|OptionSetValues|[LocalizedText](../../DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

