<!-- datatype -->
## DataTypeNode
  
<!-- end of description -->
The fields of the DataTypeNode DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|DataTypeNode|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;isAbstract|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)|If TRUE the type is abstract and only subtypes of it appear in the address space.|
|&nbsp;&nbsp;&nbsp;&nbsp;dataTypeDefinition|[Structure](../../../Part3/DataTypes/Structure/readme.md)|Provides the metadata and encoding information for custom DataTypes.|

The representation of the DataTypeNode DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=282|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|DataTypeNode|
|IsAbstract|False|
|BaseType|[TypeNode](../../../Part3/Services/TypeNode/readme.md)|
|Categories|Part3/Services|

