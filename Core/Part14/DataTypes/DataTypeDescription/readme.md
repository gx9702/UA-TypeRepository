<!-- datatype -->
## DataTypeDescription
This Structure DataType is the abstract base type for all DataType descriptions containing the DataType NodeId and the definition for custom DataTypes like Structures and Enumerations. The DataTypeDescription is formally defined in Table A.3.  
<!-- end of description -->
The fields of the DataTypeDescription DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|DataTypeDescription|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;dataTypeId|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;name|[QualifiedName](../../../Part3/DataTypes/QualifiedName/readme.md)||

The representation of the DataTypeDescription DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=14525|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|DataTypeDescription|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part14|

The references from the DataTypeDescription DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|StructureDescription||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|EnumDescription||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|SimpleTypeDescription||||

