<!-- datatype -->
## PublishedEventsDataType
This Structure DataType is used to represent PublishedEvents specific parameters. It is a subtype of the PublishedDataSetSourceDataType defined in 6.2.2.5.

The PublishedEventsDataType is formally defined in Table 13.  
<!-- end of description -->
The fields of the PublishedEventsDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|PublishedEventsDataType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;eventNotifier|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;selectedFields|[SimpleAttributeOperand](../../../Part4/DataTypes/SimpleAttributeOperand/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;filter|[ContentFilter](../../../Part4/DataTypes/ContentFilter/readme.md)||

The representation of the PublishedEventsDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15582|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|PublishedEventsDataType|
|IsAbstract|False|
|BaseType|[PublishedDataSetSourceDataType](../../../Part14/DataTypes/PublishedDataSetSourceDataType/readme.md)|
|Categories|Part14|

