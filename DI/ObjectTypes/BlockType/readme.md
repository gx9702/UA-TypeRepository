<!-- objecttype -->
## BlockType
Adds the concept of Blocks needed for block-oriented FieldDevices  
<!-- end of text -->
The representation of the BlockType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|ns=1;i=1003|
|NamespaceUri|http://opcfoundation.org/UA/DI/|
|BrowseName|BlockType|
|NodeClass|ObjectType|
|IsAbstract|True|
|BaseType|[TopologyElementType](../../ObjectTypes/TopologyElementType/readme.md)|
|Categories||

The references from the BlockType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[RevisionCounter](#RevisionCounter)|[UInt32](../../../Core/Part3/DataTypes/UInt32/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ActualMode](#ActualMode)|[LocalizedText](../../../Core/Part3/DataTypes/LocalizedText/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[PermittedMode](#PermittedMode)|[LocalizedText](../../../Core/Part3/DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[NormalMode](#NormalMode)|[LocalizedText](../../../Core/Part3/DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[TargetMode](#TargetMode)|[LocalizedText](../../../Core/Part3/DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|


