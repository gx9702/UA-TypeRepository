<!-- objecttype -->
## TemporaryFileTransferType
  
<!-- end of text -->
The representation of the TemporaryFileTransferType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15744|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|TemporaryFileTransferType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[BaseObjectType](../../ObjectTypes/BaseObjectType/readme.md)|
|Categories||

The references from the TemporaryFileTransferType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ClientProcessingTimeout](#ClientProcessingTimeout)|[Duration](../../DataTypes/Duration/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[GenerateFileForRead](#GenerateFileForRead)|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[GenerateFileForWrite](#GenerateFileForWrite)|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[CloseAndCommit](#CloseAndCommit)|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[&lt;TransferState&gt;](#&lt;TransferState&gt;)||[FileTransferStateMachineType](../../ObjectTypes/FileTransferStateMachineType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|

### <a name="GenerateFileForRead"></a>GenerateFileForRead
  
**Signature**
```
    GenerateFileForRead(
        [in]  BaseDataType GenerateOptions
        [in]  NodeId FileNodeId
        [in]  UInt32 FileHandle
        [in]  NodeId CompletionStateMachine
    );
```

|Argument|Description|
|---|---|
|GenerateOptions||
|FileNodeId||
|FileHandle||
|CompletionStateMachine||

### <a name="GenerateFileForWrite"></a>GenerateFileForWrite
  
**Signature**
```
    GenerateFileForWrite(
        [in]  BaseDataType GenerateOptions
        [in]  NodeId FileNodeId
        [in]  UInt32 FileHandle
    );
```

|Argument|Description|
|---|---|
|GenerateOptions||
|FileNodeId||
|FileHandle||

### <a name="CloseAndCommit"></a>CloseAndCommit
  
**Signature**
```
    CloseAndCommit(
        [in]  UInt32 FileHandle
        [in]  NodeId CompletionStateMachine
    );
```

|Argument|Description|
|---|---|
|FileHandle||
|CompletionStateMachine||


