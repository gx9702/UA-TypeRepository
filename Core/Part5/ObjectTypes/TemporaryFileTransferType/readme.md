<!-- objecttype -->
## TemporaryFileTransferType
The representation of the TemporaryFileTransferType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|TemporaryFileTransferType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[BaseObjectType](../../../Part5/ObjectTypes/BaseObjectType/readme.md)|

The references from the TemporaryFileTransferType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|ClientProcessingTimeout|[Duration](../../../Part3/DataTypes/Duration/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|GenerateFileForRead|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|GenerateFileForWrite|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|CloseAndCommit|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|&lt;TransferState&gt;||[FileTransferStateMachineType](../../Part5/ObjectTypes/FileTransferStateMachineType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|

