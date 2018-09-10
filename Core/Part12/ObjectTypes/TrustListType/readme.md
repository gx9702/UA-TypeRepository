<!-- objecttype -->
## TrustListType
The representation of the TrustListType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|TrustListType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[FileType](../../../Part5/ObjectTypes/FileType/readme.md)|

The references from the TrustListType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|LastUpdateTime|[UtcTime](../../../Part3/DataTypes/UtcTime/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|OpenWithMasks|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|CloseAndUpdate|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|AddCertificate|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|RemoveCertificate|||[Optional](../../Objects/Optional/readme.md)|

