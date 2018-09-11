<!-- datatype -->
## PubSubConfigurationDataType
This Structure DataType is used to represent the PubSub configuration of an OPC UA Application. The PubSubConfigurationDataType is formally defined in Table 49.  
<!-- end of description -->
The fields of the PubSubConfigurationDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|PubSubConfigurationDataType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;publishedDataSets|[PublishedDataSetDataType](../../../Part14/DataTypes/PublishedDataSetDataType/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;connections|[PubSubConnectionDataType](../../../Part14/DataTypes/PubSubConnectionDataType/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;enabled|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)||

The representation of the PubSubConfigurationDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15530|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|PubSubConfigurationDataType|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part14|

