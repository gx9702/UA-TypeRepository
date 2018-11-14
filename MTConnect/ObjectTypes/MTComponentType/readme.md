<!-- objecttype -->
## MTComponentType
  
<!-- end of text -->
The representation of the MTComponentType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|ns=1;i=2021|
|NamespaceUri|http://opcfoundation.org/UA/MTConnect/v2/|
|BrowseName|MTComponentType|
|NodeClass|ObjectType|
|IsAbstract|True|
|BaseType|[BaseObjectType](../../../Core/ObjectTypes/BaseObjectType/readme.md)|
|Categories||

The references from the MTComponentType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Core/ReferenceTypes/HasProperty/readme.md)|Variable|[XmlId](#XmlId)|[String](../../../Core/DataTypes/String/readme.md)|[PropertyType](../../../Core/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasProperty](../../../Core/ReferenceTypes/HasProperty/readme.md)|Variable|[Name](#Name)|[String](../../../Core/DataTypes/String/readme.md)|[PropertyType](../../../Core/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/ReferenceTypes/HasProperty/readme.md)|Variable|[NativeName](#NativeName)|[String](../../../Core/DataTypes/String/readme.md)|[PropertyType](../../../Core/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/ReferenceTypes/HasProperty/readme.md)|Variable|[Uuid](#Uuid)|[String](../../../Core/DataTypes/String/readme.md)|[PropertyType](../../../Core/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/ReferenceTypes/HasProperty/readme.md)|Variable|[SampleRate](#SampleRate)|[Float](../../../Core/DataTypes/Float/readme.md)|[PropertyType](../../../Core/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/ReferenceTypes/HasProperty/readme.md)|Variable|[SampleInterval](#SampleInterval)|[Float](../../../Core/DataTypes/Float/readme.md)|[PropertyType](../../../Core/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasComponent](../../../Core/ReferenceTypes/HasComponent/readme.md)|Object|[Description](#Description)||[MTDescriptionType](../../ObjectTypes/MTDescriptionType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasComponent](../../../Core/ReferenceTypes/HasComponent/readme.md)|Object|[Configuration](#Configuration)||[MTConfigurationType](../../ObjectTypes/MTConfigurationType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[Organizes](../../../Core/ReferenceTypes/Organizes/readme.md)|Object|[Components](#Components)||[FolderType](../../../Core/ObjectTypes/FolderType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[Organizes](../../../Core/ReferenceTypes/Organizes/readme.md)|Object|[Compositions](#Compositions)||[FolderType](../../../Core/ObjectTypes/FolderType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasComponent](../../../Core/ReferenceTypes/HasComponent/readme.md)|Object|[Components](#Components)||[FolderType](../../../Core/ObjectTypes/FolderType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasComponent](../../../Core/ReferenceTypes/HasComponent/readme.md)|Object|[Compositions](#Compositions)||[FolderType](../../../Core/ObjectTypes/FolderType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasSubtype](../../../Core/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[MTDeviceType](#MTDeviceType)||||


