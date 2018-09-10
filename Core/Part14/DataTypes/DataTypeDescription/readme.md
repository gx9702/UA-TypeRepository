<!-- datatype -->
## DataTypeDescription
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
|BrowseName|DataTypeDescription|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

The references from the DataTypeDescription DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|StructureDescription||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|EnumDescription||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|SimpleTypeDescription||||

