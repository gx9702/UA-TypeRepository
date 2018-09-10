<!-- objecttype -->
## StreamType
The representation of the StreamType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|StreamType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[TopologyElementType](../../../DI/ObjectTypes/TopologyElementType/readme.md)|

The references from the StreamType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|ParameterSet||[BaseObjectType](../../../Core/Part5/ObjectTypes/BaseObjectType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|&lt;GroupIdentifier&gt;||[FunctionalGroupType](../../../DI/ObjectTypes/FunctionalGroupType/readme.md)|[OptionalPlaceholder](../../../Core/Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|Configuration||[FunctionalGroupType](../../../DI/ObjectTypes/FunctionalGroupType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|Status||[FunctionalGroupType](../../../DI/ObjectTypes/FunctionalGroupType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|AcquisitionSettings||[FunctionalGroupType](../../../DI/ObjectTypes/FunctionalGroupType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|AcquisitionStatus||[FunctionalGroupType](../../../DI/ObjectTypes/FunctionalGroupType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|AcquisitionData||[FunctionalGroupType](../../../DI/ObjectTypes/FunctionalGroupType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|ChemometricModelSettings||[FunctionalGroupType](../../../DI/ObjectTypes/FunctionalGroupType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|Context||[FunctionalGroupType](../../../DI/ObjectTypes/FunctionalGroupType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasSubtype](../../../Core/Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|SpectrometerDeviceStreamType||||
|[HasSubtype](../../../Core/Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|MassSpectrometerDeviceStreamType||||
|[HasSubtype](../../../Core/Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|ParticleSizeMonitorDeviceStreamType||||
|[HasSubtype](../../../Core/Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|AcousticSpectrometerDeviceStreamType||||
|[HasSubtype](../../../Core/Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|ChromatographDeviceStreamType||||
|[HasSubtype](../../../Core/Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|MNRDeviceStreamType||||

