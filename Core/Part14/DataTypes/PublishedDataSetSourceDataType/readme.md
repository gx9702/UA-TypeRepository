<!-- datatype -->
## PublishedDataSetSourceDataType
The PublishedDataSetSourceDataType Structure is an abstract base type without fields for the definition of the PublishedDataSet source. Its representation in the AddressSpace is defined in Table 10.  
<!-- end of description -->
The fields of the PublishedDataSetSourceDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|PublishedDataSetSourceDataType|Structure||

The representation of the PublishedDataSetSourceDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15580|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|PublishedDataSetSourceDataType|
|IsAbstract|True|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part14|

The references from the PublishedDataSetSourceDataType DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|PublishedDataItemsDataType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|PublishedEventsDataType||||

