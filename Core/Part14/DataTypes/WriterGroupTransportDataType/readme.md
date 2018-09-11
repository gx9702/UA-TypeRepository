<!-- datatype -->
## WriterGroupTransportDataType
This Structure DataType is an abstract base type for transport mapping specific WriterGroup parameters. The abstract DataType does not define fields.

The WriterGroupTransportDataType Structure representation in the AddressSpace is defined in Table 24.  
<!-- end of description -->
The fields of the WriterGroupTransportDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|WriterGroupTransportDataType|Structure||

The representation of the WriterGroupTransportDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15611|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|WriterGroupTransportDataType|
|IsAbstract|True|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part14|

The references from the WriterGroupTransportDataType DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|DatagramWriterGroupTransportDataType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|BrokerWriterGroupTransportDataType||||

