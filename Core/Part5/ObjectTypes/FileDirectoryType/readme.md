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
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[&lt;FileDirectoryName&gt;](#&lt;FileDirectoryName&gt;)||[FileDirectoryType](../../Part5/ObjectTypes/FileDirectoryType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[&lt;FileName&gt;](#&lt;FileName&gt;)||[FileType](../../Part5/ObjectTypes/FileType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[CreateDirectory](#CreateDirectory)|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[CreateFile](#CreateFile)|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[Delete](#Delete)|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[MoveOrCopy](#MoveOrCopy)|||[Mandatory](../../Objects/Mandatory/readme.md)|

### <a name="CreateDirectory"></a>CreateDirectory

**Signature**
```
    CreateDirectory(
        [in]  String DirectoryName
        [in]  NodeId DirectoryNodeId
    );
```

|Argument|Description|
|---|---|
|DirectoryName||
|DirectoryNodeId||

### <a name="CreateFile"></a>CreateFile

**Signature**
```
    CreateFile(
        [in]  String FileName
        [in]  Boolean RequestFileOpen
        [in]  NodeId FileNodeId
        [in]  UInt32 FileHandle
    );
```

|Argument|Description|
|---|---|
|FileName||
|RequestFileOpen||
|FileNodeId||
|FileHandle||

### <a name="Delete"></a>Delete

**Signature**
```
    Delete(
        [in]  NodeId ObjectToDelete
    );
```

|Argument|Description|
|---|---|
|ObjectToDelete||

### <a name="MoveOrCopy"></a>MoveOrCopy

**Signature**
```
    MoveOrCopy(
        [in]  NodeId ObjectToMoveOrCopy
        [in]  NodeId TargetDirectory
        [in]  Boolean CreateCopy
        [in]  String NewName
        [in]  NodeId NewNodeId
    );
```

|Argument|Description|
|---|---|
|ObjectToMoveOrCopy||
|TargetDirectory||
|CreateCopy||
|NewName||
|NewNodeId||


