<!-- datatype -->
## MonitoringParameters
  
<!-- end of description -->
The fields of the MonitoringParameters DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|MonitoringParameters|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;clientHandle|[IntegerId](../../../Part4/DataTypes/IntegerId/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;samplingInterval|[Duration](../../../Part3/DataTypes/Duration/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;filter|[Structure](../../../Part3/DataTypes/Structure/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;queueSize|[Counter](../../../Part4/DataTypes/Counter/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;discardOldest|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)||

The representation of the MonitoringParameters DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=740|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|MonitoringParameters|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part4/Services|

