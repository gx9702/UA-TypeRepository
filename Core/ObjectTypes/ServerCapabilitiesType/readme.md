<!-- objecttype -->
## ServerCapabilitiesType
Describes the capabilities supported by the server.  
<!-- end of text -->
The representation of the ServerCapabilitiesType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2013|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|ServerCapabilitiesType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[BaseObjectType](../../ObjectTypes/BaseObjectType/readme.md)|
|Categories||

The references from the ServerCapabilitiesType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ServerProfileArray](#ServerProfileArray)|[String](../../DataTypes/String/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[LocaleIdArray](#LocaleIdArray)|[LocaleId](../../DataTypes/LocaleId/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[MinSupportedSampleRate](#MinSupportedSampleRate)|[Duration](../../DataTypes/Duration/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[MaxBrowseContinuationPoints](#MaxBrowseContinuationPoints)|[UInt16](../../DataTypes/UInt16/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[MaxQueryContinuationPoints](#MaxQueryContinuationPoints)|[UInt16](../../DataTypes/UInt16/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[MaxHistoryContinuationPoints](#MaxHistoryContinuationPoints)|[UInt16](../../DataTypes/UInt16/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[SoftwareCertificates](#SoftwareCertificates)|[SignedSoftwareCertificate](../../DataTypes/SignedSoftwareCertificate/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[MaxArrayLength](#MaxArrayLength)|[UInt32](../../DataTypes/UInt32/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[MaxStringLength](#MaxStringLength)|[UInt32](../../DataTypes/UInt32/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[MaxByteStringLength](#MaxByteStringLength)|[UInt32](../../DataTypes/UInt32/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[OperationLimits](#OperationLimits)||[OperationLimitsType](../../ObjectTypes/OperationLimitsType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[ModellingRules](#ModellingRules)||[FolderType](../../ObjectTypes/FolderType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[AggregateFunctions](#AggregateFunctions)||[FolderType](../../ObjectTypes/FolderType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[&lt;VendorCapability&gt;](#&lt;VendorCapability&gt;)|[BaseDataType](../../DataTypes/BaseDataType/readme.md)|[ServerVendorCapabilityType](../../VariableTypes/ServerVendorCapabilityType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[RoleSet](#RoleSet)||[RoleSetType](../../ObjectTypes/RoleSetType/readme.md)|[Optional](../../Objects/Optional/readme.md)|


