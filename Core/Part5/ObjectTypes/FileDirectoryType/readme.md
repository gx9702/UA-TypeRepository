<!-- objecttype -->
## FileDirectoryType
The representation of the FileDirectoryType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|FileDirectoryType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[FolderType](../../../Part5/ObjectTypes/FolderType/readme.md)|

The references from the FileDirectoryType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|&lt;FileDirectoryName&gt;||[FileDirectoryType](../../Part5/ObjectTypes/FileDirectoryType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|&lt;FileName&gt;||[FileType](../../Part5/ObjectTypes/FileType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|CreateDirectory|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|CreateFile|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|Delete|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|MoveOrCopy|||[Mandatory](../../Objects/Mandatory/readme.md)|

