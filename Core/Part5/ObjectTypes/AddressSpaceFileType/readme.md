<!-- objecttype -->
## AddressSpaceFileType
A file used to store a namespace exported from the server.  
The representation of the AddressSpaceFileType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|AddressSpaceFileType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[FileType](../../../Part5/ObjectTypes/FileType/readme.md)|

The references from the AddressSpaceFileType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[ExportNamespace](#ExportNamespace)|||[Optional](../../Objects/Optional/readme.md)|

### <a name="ExportNamespace"></a>ExportNamespace
  
**Signature**
```
    ExportNamespace(    );
```

