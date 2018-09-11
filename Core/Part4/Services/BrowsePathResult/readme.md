<!-- datatype -->
## BrowsePathResult
The result of a translate opearation.  
<!-- end of description -->
The fields of the BrowsePathResult DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|BrowsePathResult|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;statusCode|[StatusCode](../../../Part4/DataTypes/StatusCode/readme.md)|A code indicating any error during the operation.|
|&nbsp;&nbsp;&nbsp;&nbsp;targets|[BrowsePathTarget](../../../Part4/Services/BrowsePathTarget/readme.md)[]|A list of nodes found. The first element matches the type definition.|

The representation of the BrowsePathResult DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=549|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|BrowsePathResult|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part4/Services|

