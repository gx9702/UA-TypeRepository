<!-- datatype -->
## NodeAttributes
<!-- end of description -->
The fields of the NodeAttributes DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|NodeAttributes|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;specifiedAttributes|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)|A mask indicating which attributes have been provided.|
|&nbsp;&nbsp;&nbsp;&nbsp;displayName|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)|A human readable name for the node.|
|&nbsp;&nbsp;&nbsp;&nbsp;description|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)|A description for the node.|
|&nbsp;&nbsp;&nbsp;&nbsp;writeMask|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)|A mask which specifies which attributes are writable.|
|&nbsp;&nbsp;&nbsp;&nbsp;userWriteMask|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)|A mask which specifies which attributes are writable by the current user.|

The representation of the NodeAttributes DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|NodeAttributes|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

The references from the NodeAttributes DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|ObjectAttributes||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|VariableAttributes||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|MethodAttributes||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|ObjectTypeAttributes||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|VariableTypeAttributes||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|ReferenceTypeAttributes||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|DataTypeAttributes||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|ViewAttributes||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|GenericAttributes||||

