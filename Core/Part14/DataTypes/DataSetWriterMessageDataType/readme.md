<!-- datatype -->
## DataSetWriterMessageDataType
This Structure DataType is an abstract base type for message mapping specific DataSetWriter parameters. The abstract DataType does not define fields.

The DataSetWriterMessageDataType Structure representation in the AddressSpace is defined in Table 19.  
<!-- end of description -->
The fields of the DataSetWriterMessageDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|DataSetWriterMessageDataType|Structure||

The representation of the DataSetWriterMessageDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15605|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|DataSetWriterMessageDataType|
|IsAbstract|True|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part14|

The references from the DataSetWriterMessageDataType DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|UadpDataSetWriterMessageDataType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|JsonDataSetWriterMessageDataType||||

