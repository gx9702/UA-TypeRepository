<!-- objecttype -->
## AnalyserDeviceType

The representation of the AnalyserDeviceType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|AnalyserDeviceType|
|NodeClass|ObjectType|
|IsAbtract|True|
|BaseType|[DeviceType](../../../DI/ObjectTypes/DeviceType/readme.md)|

The references from the AnalyserDeviceType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[ParameterSet](#ParameterSet)||[BaseObjectType](../../../Core/Part5/ObjectTypes/BaseObjectType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[MethodSet](#MethodSet)||[BaseObjectType](../../../Core/Part5/ObjectTypes/BaseObjectType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Identification](#Identification)||[FunctionalGroupType](../../../DI/ObjectTypes/FunctionalGroupType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Configuration](#Configuration)||[FunctionalGroupType](../../../DI/ObjectTypes/FunctionalGroupType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Status](#Status)||[FunctionalGroupType](../../../DI/ObjectTypes/FunctionalGroupType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[FactorySettings](#FactorySettings)||[FunctionalGroupType](../../../DI/ObjectTypes/FunctionalGroupType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[AnalyserStateMachine](#AnalyserStateMachine)||[AnalyserDeviceStateMachineType](../../ObjectTypes/AnalyserDeviceStateMachineType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[&lt;ChannelIdentifier&gt;](#&lt;ChannelIdentifier&gt;)||[AnalyserChannelType](../../ObjectTypes/AnalyserChannelType/readme.md)|[OptionalPlaceholder](../../../Core/Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|[&lt;AccessorySlotIdentifier&gt;](#&lt;AccessorySlotIdentifier&gt;)||[AccessorySlotType](../../ObjectTypes/AccessorySlotType/readme.md)|[OptionalPlaceholder](../../../Core/Objects/OptionalPlaceholder/readme.md)|
|[HasSubtype](../../../Core/Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[SpectrometerDeviceType](#SpectrometerDeviceType)||||
|[HasSubtype](../../../Core/Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[ParticleSizeMonitorDeviceType](#ParticleSizeMonitorDeviceType)||||
|[HasSubtype](../../../Core/Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[ChromatographDeviceType](#ChromatographDeviceType)||||
|[HasSubtype](../../../Core/Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[MassSpectrometerDeviceType](#MassSpectrometerDeviceType)||||
|[HasSubtype](../../../Core/Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AcousticSpectrometerDeviceType](#AcousticSpectrometerDeviceType)||||
|[HasSubtype](../../../Core/Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[NMRDeviceType](#NMRDeviceType)||||


