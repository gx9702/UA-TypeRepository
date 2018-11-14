<!-- objecttype -->
## FileType
An object that represents a file that can be accessed via the server.  
<!-- end of text -->
The representation of the FileType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=11575|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|FileType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[BaseObjectType](../../ObjectTypes/BaseObjectType/readme.md)|
|Categories||

The references from the FileType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[Size](#Size)|[UInt64](../../DataTypes/UInt64/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[Writable](#Writable)|[Boolean](../../DataTypes/Boolean/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[UserWritable](#UserWritable)|[Boolean](../../DataTypes/Boolean/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[OpenCount](#OpenCount)|[UInt16](../../DataTypes/UInt16/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[MimeType](#MimeType)|[String](../../DataTypes/String/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[Open](#Open)|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[Close](#Close)|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[Read](#Read)|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[Write](#Write)|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[GetPosition](#GetPosition)|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[SetPosition](#SetPosition)|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AddressSpaceFileType](#AddressSpaceFileType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[TrustListType](#TrustListType)||||

### <a name="Open"></a>Open
  
**Signature**
```
    Open(
        [in]  Byte Mode
        [in]  UInt32 FileHandle
    );
```

|Argument|Description|
|---|---|
|Mode||
|FileHandle||

### <a name="Close"></a>Close
  
**Signature**
```
    Close(
        [in]  UInt32 FileHandle
    );
```

|Argument|Description|
|---|---|
|FileHandle||

### <a name="Read"></a>Read
  
**Signature**
```
    Read(
        [in]  UInt32 FileHandle
        [in]  Int32 Length
        [in]  ByteString Data
    );
```

|Argument|Description|
|---|---|
|FileHandle||
|Length||
|Data||

### <a name="Write"></a>Write
  
**Signature**
```
    Write(
        [in]  UInt32 FileHandle
        [in]  ByteString Data
    );
```

|Argument|Description|
|---|---|
|FileHandle||
|Data||

### <a name="GetPosition"></a>GetPosition
  
**Signature**
```
    GetPosition(
        [in]  UInt32 FileHandle
        [in]  UInt64 Position
    );
```

|Argument|Description|
|---|---|
|FileHandle||
|Position||

### <a name="SetPosition"></a>SetPosition
  
**Signature**
```
    SetPosition(
        [in]  UInt32 FileHandle
        [in]  UInt64 Position
    );
```

|Argument|Description|
|---|---|
|FileHandle||
|Position||


