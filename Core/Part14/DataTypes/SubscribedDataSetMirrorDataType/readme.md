<!-- datatype -->
## SubscribedDataSetMirrorDataType
This Structure DataType is used to represent SubscribedDataSetMirror specific parameters. It is a subtype of the SubscribedDataSetDataType defined in 6.2.9.1.

The SubscribedDataSetMirrorDataType is formally defined in Table 46.  
<!-- end of description -->
The fields of the SubscribedDataSetMirrorDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|SubscribedDataSetMirrorDataType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;parentNodeName|[String](../../../Part3/DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;rolePermissions|[RolePermissionType](../../../Part3/DataTypes/RolePermissionType/readme.md)[]||

The representation of the SubscribedDataSetMirrorDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15635|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|SubscribedDataSetMirrorDataType|
|IsAbstract|False|
|BaseType|[SubscribedDataSetDataType](../../../Part14/DataTypes/SubscribedDataSetDataType/readme.md)|
|Categories|Part14|

