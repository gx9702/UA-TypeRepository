<!-- datatype -->
## BrowseResult
The result of a browse operation.  
<!-- end of description -->
The fields of the BrowseResult DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|BrowseResult|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;statusCode|[StatusCode](../../../Part4/DataTypes/StatusCode/readme.md)|A code indicating any error during the operation.|
|&nbsp;&nbsp;&nbsp;&nbsp;continuationPoint|[ContinuationPoint](../../../Part4/DataTypes/ContinuationPoint/readme.md)|A value that indicates the operation is incomplete and can be continued by calling BrowseNext.|
|&nbsp;&nbsp;&nbsp;&nbsp;references|[ReferenceDescription](../../../Part4/Services/ReferenceDescription/readme.md)[]|A list of references that meet the criteria specified in the request.|

The representation of the BrowseResult DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=522|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|BrowseResult|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part4/Services|

