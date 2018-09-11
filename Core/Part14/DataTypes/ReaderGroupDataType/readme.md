<!-- datatype -->
## ReaderGroupDataType
This Structure DataType is used to represent the configuration parameters for ReaderGroups. The ReaderGroupDataType is formally defined in Table 32.  
<!-- end of description -->
The fields of the ReaderGroupDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|ReaderGroupDataType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;transportSettings|[Structure](../../../Part3/DataTypes/Structure/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;messageSettings|[Structure](../../../Part3/DataTypes/Structure/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;dataSetReaders|[DataSetReaderDataType](../../../Part14/DataTypes/DataSetReaderDataType/readme.md)[]||

The representation of the ReaderGroupDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15520|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|ReaderGroupDataType|
|IsAbstract|False|
|BaseType|[PubSubGroupDataType](../../../Part14/DataTypes/PubSubGroupDataType/readme.md)|
|Categories|Part14|

