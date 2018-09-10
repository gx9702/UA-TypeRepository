<!-- datatype -->
## ReadProcessedDetails
<!-- end of description -->
The fields of the ReadProcessedDetails DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|ReadProcessedDetails|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;startTime|[UtcTime](../../../Part3/DataTypes/UtcTime/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;endTime|[UtcTime](../../../Part3/DataTypes/UtcTime/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;processingInterval|[Duration](../../../Part3/DataTypes/Duration/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;aggregateType|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;aggregateConfiguration|[AggregateConfiguration](../../../Part4/DataTypes/AggregateConfiguration/readme.md)||

The representation of the ReadProcessedDetails DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|ReadProcessedDetails|
|IsAbtract|False|
|BaseType|[HistoryReadDetails](../../../Part4/Services/HistoryReadDetails/readme.md)|

