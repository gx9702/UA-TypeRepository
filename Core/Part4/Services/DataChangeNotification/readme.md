<!-- datatype -->
## DataChangeNotification
  
<!-- end of description -->
The fields of the DataChangeNotification DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|DataChangeNotification|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;monitoredItems|[MonitoredItemNotification](../../../Part4/Services/MonitoredItemNotification/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;diagnosticInfos|[DiagnosticInfo](../../../Part4/DataTypes/DiagnosticInfo/readme.md)[]||

The representation of the DataChangeNotification DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=809|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|DataChangeNotification|
|IsAbstract|False|
|BaseType|[NotificationData](../../../Part4/Services/NotificationData/readme.md)|
|Categories|Part4/Services|

