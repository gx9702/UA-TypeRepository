<!-- datatype -->
## ReadRawModifiedDetails
  
<!-- end of description -->
The fields of the ReadRawModifiedDetails DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|ReadRawModifiedDetails|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;isReadModified|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;startTime|[UtcTime](../../../Part3/DataTypes/UtcTime/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;endTime|[UtcTime](../../../Part3/DataTypes/UtcTime/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;numValuesPerNode|[Counter](../../../Part4/DataTypes/Counter/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;returnBounds|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)||

The representation of the ReadRawModifiedDetails DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=647|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|ReadRawModifiedDetails|
|IsAbstract|False|
|BaseType|[HistoryReadDetails](../../../Part4/Services/HistoryReadDetails/readme.md)|
|Categories|Part4/Services|

