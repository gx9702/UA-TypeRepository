<!-- datatype -->
## AggregateFilter
  
<!-- end of description -->
The fields of the AggregateFilter DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|AggregateFilter|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;startTime|[UtcTime](../../../Part3/DataTypes/UtcTime/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;aggregateType|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;processingInterval|[Duration](../../../Part3/DataTypes/Duration/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;aggregateConfiguration|[AggregateConfiguration](../../../Part4/DataTypes/AggregateConfiguration/readme.md)||

The representation of the AggregateFilter DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=728|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|AggregateFilter|
|IsAbstract|False|
|BaseType|[MonitoringFilter](../../../Part4/DataTypes/MonitoringFilter/readme.md)|
|Categories|Part4/Services|

