<!-- objecttype -->
## SpectrometerDeviceStreamType
The representation of the SpectrometerDeviceStreamType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|SpectrometerDeviceStreamType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[StreamType](../../ObjectTypes/StreamType/readme.md)|

The references from the SpectrometerDeviceStreamType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|ParameterSet||[BaseObjectType](../../../Core/Part5/ObjectTypes/BaseObjectType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|Configuration||[FunctionalGroupType](../../../DI/ObjectTypes/FunctionalGroupType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|AcquisitionSettings||[FunctionalGroupType](../../../DI/ObjectTypes/FunctionalGroupType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|AcquisitionStatus||[FunctionalGroupType](../../../DI/ObjectTypes/FunctionalGroupType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|AcquisitionData||[FunctionalGroupType](../../../DI/ObjectTypes/FunctionalGroupType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Object|FactorySettings||[BaseObjectType](../../../Core/Part5/ObjectTypes/BaseObjectType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|

