<!-- objecttype -->
## MTSensorConfigurationType
  
<!-- end of text -->
The representation of the MTSensorConfigurationType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|ns=1;i=2046|
|NamespaceUri|http://opcfoundation.org/UA/MTConnect/v2/|
|BrowseName|MTSensorConfigurationType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[MTConfigurationType](../../ObjectTypes/MTConfigurationType/readme.md)|
|Categories||

The references from the MTSensorConfigurationType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Core/ReferenceTypes/HasProperty/readme.md)|Variable|[FirwareVersion](#FirwareVersion)|[String](../../../Core/DataTypes/String/readme.md)|[PropertyType](../../../Core/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasProperty](../../../Core/ReferenceTypes/HasProperty/readme.md)|Variable|[CalibrationDate](#CalibrationDate)|[UtcTime](../../../Core/DataTypes/UtcTime/readme.md)|[PropertyType](../../../Core/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/ReferenceTypes/HasProperty/readme.md)|Variable|[NextCalibrationDate](#NextCalibrationDate)|[UtcTime](../../../Core/DataTypes/UtcTime/readme.md)|[PropertyType](../../../Core/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/ReferenceTypes/HasProperty/readme.md)|Variable|[CalibrationInitials](#CalibrationInitials)|[String](../../../Core/DataTypes/String/readme.md)|[PropertyType](../../../Core/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[Organizes](../../../Core/ReferenceTypes/Organizes/readme.md)|Object|[Channels](#Channels)||[FolderType](../../../Core/ObjectTypes/FolderType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasComponent](../../../Core/ReferenceTypes/HasComponent/readme.md)|Object|[Channels](#Channels)||[FolderType](../../../Core/ObjectTypes/FolderType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|


