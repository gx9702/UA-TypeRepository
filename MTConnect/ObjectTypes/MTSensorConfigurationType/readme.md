<!-- objecttype -->
## MTSensorConfigurationType
  
<!-- end of text -->
The representation of the MTSensorConfigurationType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|ns=1;i=2045|
|NamespaceUri|http://opcfoundation.org/UA/MTConnect/v2|
|BrowseName|MTSensorConfigurationType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[MTConfigurationType](../../ObjectTypes/MTConfigurationType/readme.md)|
|Categories||

The references from the MTSensorConfigurationType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[FirwareVersion](#FirwareVersion)|[String](../../../Core/Part3/DataTypes/String/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[CalibrationDate](#CalibrationDate)|[UtcTime](../../../Core/Part3/DataTypes/UtcTime/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[NextCalibrationDate](#NextCalibrationDate)|[UtcTime](../../../Core/Part3/DataTypes/UtcTime/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[CalibrationInitials](#CalibrationInitials)|[String](../../../Core/Part3/DataTypes/String/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[Organizes](../../../Core/Part3/ReferenceTypes/Organizes/readme.md)|Object|[Channels](#Channels)||[FolderType](../../../Core/Part5/ObjectTypes/FolderType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Channels](#Channels)||[FolderType](../../../Core/Part5/ObjectTypes/FolderType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|


