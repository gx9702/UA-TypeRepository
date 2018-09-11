<!-- datatype -->
## PublishResponse
  
<!-- end of description -->
The fields of the PublishResponse DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|PublishResponse|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;responseHeader|[ResponseHeader](../../../Part4/Services/ResponseHeader/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;subscriptionId|[IntegerId](../../../Part4/DataTypes/IntegerId/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;availableSequenceNumbers|[Counter](../../../Part4/DataTypes/Counter/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;moreNotifications|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;notificationMessage|[NotificationMessage](../../../Part4/Services/NotificationMessage/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;results|[StatusCode](../../../Part4/DataTypes/StatusCode/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;diagnosticInfos|[DiagnosticInfo](../../../Part4/DataTypes/DiagnosticInfo/readme.md)[]||

The representation of the PublishResponse DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=827|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|PublishResponse|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part4/Services|

