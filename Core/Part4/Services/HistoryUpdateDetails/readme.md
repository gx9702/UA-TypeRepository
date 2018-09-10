<!-- datatype -->
## HistoryUpdateDetails
<!-- end of description -->
The fields of the HistoryUpdateDetails DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|HistoryUpdateDetails|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;nodeId|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)||

The representation of the HistoryUpdateDetails DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|HistoryUpdateDetails|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

The references from the HistoryUpdateDetails DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|UpdateDataDetails||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|UpdateStructureDataDetails||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|UpdateEventDetails||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|DeleteRawModifiedDetails||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|DeleteAtTimeDetails||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|DeleteEventDetails||||

