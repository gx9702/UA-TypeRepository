<!-- datatype -->
## NotificationMessage
  
<!-- end of description -->
The fields of the NotificationMessage DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|NotificationMessage|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;sequenceNumber|[Counter](../../../Part4/DataTypes/Counter/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;publishTime|[UtcTime](../../../Part3/DataTypes/UtcTime/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;notificationData|[Structure](../../../Part3/DataTypes/Structure/readme.md)[]||

The representation of the NotificationMessage DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=803|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|NotificationMessage|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part4/Services|

