<!-- datatype -->
## MethodAttributes
The attributes for a method node.  
<!-- end of description -->
The fields of the MethodAttributes DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|MethodAttributes|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;executable|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)|If TRUE the method can be called.|
|&nbsp;&nbsp;&nbsp;&nbsp;userExecutable|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)|If TRUE the method can be called by the current user.|

The representation of the MethodAttributes DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=358|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|MethodAttributes|
|IsAbstract|False|
|BaseType|[NodeAttributes](../../../Part4/Services/NodeAttributes/readme.md)|
|Categories|Part4/Services|

