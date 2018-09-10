<!-- objecttype -->
## DeviceType
Defines the basic information components for all configurable elements in a device topology
The representation of the DeviceType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|DeviceType|
|NodeClass|ObjectType|
|IsAbtract|True|
|BaseType|[TopologyElementType](../../ObjectTypes/TopologyElementType/readme.md)|

The references from the DeviceType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[SerialNumber](#SerialNumber)|[String](../../../Core/Part3/DataTypes/String/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[RevisionCounter](#RevisionCounter)|[Int32](../../../Core/Part3/DataTypes/Int32/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[Manufacturer](#Manufacturer)|[LocalizedText](../../../Core/Part3/DataTypes/LocalizedText/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[Model](#Model)|[LocalizedText](../../../Core/Part3/DataTypes/LocalizedText/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[DeviceManual](#DeviceManual)|[String](../../../Core/Part3/DataTypes/String/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[DeviceRevision](#DeviceRevision)|[String](../../../Core/Part3/DataTypes/String/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[SoftwareRevision](#SoftwareRevision)|[String](../../../Core/Part3/DataTypes/String/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[HardwareRevision](#HardwareRevision)|[String](../../../Core/Part3/DataTypes/String/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[DeviceClass](#DeviceClass)|[String](../../../Core/Part3/DataTypes/String/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[DeviceHealth](#DeviceHealth)|[DeviceHealthEnumeration](../../DataTypes/DeviceHealthEnumeration/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[DeviceTypeImage](#DeviceTypeImage)||[FolderType](../../../Core/Part5/ObjectTypes/FolderType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Documentation](#Documentation)||[FolderType](../../../Core/Part5/ObjectTypes/FolderType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[ProtocolSupport](#ProtocolSupport)||[FolderType](../../../Core/Part5/ObjectTypes/FolderType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[ImageSet](#ImageSet)||[FolderType](../../../Core/Part5/ObjectTypes/FolderType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[&lt;CPIdentifier&gt;](#&lt;CPIdentifier&gt;)||[ConnectionPointType](../../ObjectTypes/ConnectionPointType/readme.md)|[OptionalPlaceholder](../../../Core/Objects/OptionalPlaceholder/readme.md)|


