<!-- datatype -->
## UpdateEventDetails
  
<!-- end of description -->
The fields of the UpdateEventDetails DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|UpdateEventDetails|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;performInsertReplace|[PerformUpdateType](../../../Part4/DataTypes/PerformUpdateType/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;filter|[EventFilter](../../../Part4/DataTypes/EventFilter/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;eventData|[HistoryEventFieldList](../../../Part4/DataTypes/HistoryEventFieldList/readme.md)[]||

The representation of the UpdateEventDetails DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=683|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|UpdateEventDetails|
|IsAbstract|False|
|BaseType|[HistoryUpdateDetails](../../../Part4/Services/HistoryUpdateDetails/readme.md)|
|Categories|Part4/Services|

