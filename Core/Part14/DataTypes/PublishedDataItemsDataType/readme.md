<!-- datatype -->
## PublishedDataItemsDataType
This Structure DataType is used to represent PublishedDataItems specific parameters. It is a subtype of the PublishedDataSetSourceDataType defined in 6.2.2.5.

The PublishedDataItemsDataType is formally defined in Table 12.  
<!-- end of description -->
The fields of the PublishedDataItemsDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|PublishedDataItemsDataType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;publishedData|[PublishedVariableDataType](../../../Part14/DataTypes/PublishedVariableDataType/readme.md)[]||

The representation of the PublishedDataItemsDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15581|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|PublishedDataItemsDataType|
|IsAbstract|False|
|BaseType|[PublishedDataSetSourceDataType](../../../Part14/DataTypes/PublishedDataSetSourceDataType/readme.md)|
|Categories|Part14|

