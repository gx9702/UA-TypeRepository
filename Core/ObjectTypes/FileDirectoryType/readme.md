<!-- objecttype -->
## FileDirectoryType
  
<!-- end of text -->
The representation of the FileDirectoryType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=13353|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|FileDirectoryType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[FolderType](../../ObjectTypes/FolderType/readme.md)|
|Categories||

The references from the FileDirectoryType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[&lt;FileDirectoryName&gt;](#&lt;FileDirectoryName&gt;)||[FileDirectoryType](../../ObjectTypes/FileDirectoryType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[&lt;FileName&gt;](#&lt;FileName&gt;)||[FileType](../../ObjectTypes/FileType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[CreateDirectory](#CreateDirectory)|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[CreateFile](#CreateFile)|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[Delete](#Delete)|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[MoveOrCopy](#MoveOrCopy)|||[Mandatory](../../Objects/Mandatory/readme.md)|

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


