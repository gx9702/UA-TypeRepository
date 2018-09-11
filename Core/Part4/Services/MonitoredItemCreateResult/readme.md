<!-- datatype -->
## MonitoredItemCreateResult
  
<!-- end of description -->
The fields of the MonitoredItemCreateResult DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|MonitoredItemCreateResult|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;statusCode|[StatusCode](../../../Part4/DataTypes/StatusCode/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;monitoredItemId|[IntegerId](../../../Part4/DataTypes/IntegerId/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;revisedSamplingInterval|[Duration](../../../Part3/DataTypes/Duration/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;revisedQueueSize|[Counter](../../../Part4/DataTypes/Counter/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;filterResult|[Structure](../../../Part3/DataTypes/Structure/readme.md)||

The representation of the MonitoredItemCreateResult DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=746|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|MonitoredItemCreateResult|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part4/Services|

