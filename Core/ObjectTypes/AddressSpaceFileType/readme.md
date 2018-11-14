<!-- objecttype -->
## AddressSpaceFileType
A file used to store a namespace exported from the server.  
<!-- end of text -->
The representation of the AddressSpaceFileType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=11595|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|AddressSpaceFileType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[FileType](../../ObjectTypes/FileType/readme.md)|
|Categories||

The references from the AddressSpaceFileType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[ExportNamespace](#ExportNamespace)|||[Optional](../../Objects/Optional/readme.md)|

### <a name="ExportNamespace"></a>ExportNamespace
  
**Signature**
```
    ExportNamespace(    );
```

