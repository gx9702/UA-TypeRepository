<!-- objecttype -->
## DatagramWriterGroupTransportType
This ObjectType represents datagram transport protocol mapping specific parameters for a WriterGroup. The DatagramWriterGroupTransportType is formally defined in Table 167.  
<!-- end of text -->
The representation of the DatagramWriterGroupTransportType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=21133|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|DatagramWriterGroupTransportType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[WriterGroupTransportType](../../../Part14/ObjectTypes/WriterGroupTransportType/readme.md)|
|Categories|Part14|

The references from the DatagramWriterGroupTransportType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[MessageRepeatCount](#MessageRepeatCount)|[Byte](../../../Part3/DataTypes/Byte/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[MessageRepeatDelay](#MessageRepeatDelay)|[Duration](../../../Part3/DataTypes/Duration/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


