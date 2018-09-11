<!-- datatype -->
## SimpleTypeDescription
This Structure DataType provides the information for DataTypes derived from built-in DataTypes. It is a subtype of Structure. The SimpleTypeDescription is formally defined in Table A.9.  
<!-- end of description -->
The fields of the SimpleTypeDescription DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|SimpleTypeDescription|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;baseDataType|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;builtInType|[Byte](../../../Part3/DataTypes/Byte/readme.md)||

The representation of the SimpleTypeDescription DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15005|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|SimpleTypeDescription|
|IsAbstract|False|
|BaseType|[DataTypeDescription](../../../Part14/DataTypes/DataTypeDescription/readme.md)|
|Categories|Part14|

