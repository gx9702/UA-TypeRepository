<!-- datatype -->
## WriterGroupMessageDataType
This Structure DataType is an abstract base type for message mapping specific WriterGroup parameters. The abstract DataType does not define fields.

The WriterGroupMessageDataType Structure representation in the AddressSpace is defined in Table 25.  
<!-- end of description -->
The fields of the WriterGroupMessageDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|WriterGroupMessageDataType|Structure||

The representation of the WriterGroupMessageDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15616|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|WriterGroupMessageDataType|
|IsAbstract|True|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part14|

The references from the WriterGroupMessageDataType DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|UadpWriterGroupMessageDataType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|JsonWriterGroupMessageDataType||||

