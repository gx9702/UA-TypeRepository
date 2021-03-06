<!-- objecttype -->
## SecurityGroupFolderType
  
<!-- end of text -->
The representation of the SecurityGroupFolderType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15452|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|SecurityGroupFolderType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[FolderType](../../ObjectTypes/FolderType/readme.md)|
|Categories||

The references from the SecurityGroupFolderType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[Organizes](../../ReferenceTypes/Organizes/readme.md)|Object|[&lt;SecurityGroupFolderName&gt;](#&lt;SecurityGroupFolderName&gt;)||[SecurityGroupFolderType](../../ObjectTypes/SecurityGroupFolderType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[&lt;SecurityGroupName&gt;](#&lt;SecurityGroupName&gt;)||[SecurityGroupType](../../ObjectTypes/SecurityGroupType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[AddSecurityGroup](#AddSecurityGroup)|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[RemoveSecurityGroup](#RemoveSecurityGroup)|||[Mandatory](../../Objects/Mandatory/readme.md)|

### <a name="AddSecurityGroup"></a>AddSecurityGroup
  
**Signature**
```
    AddSecurityGroup(
        [in]  String SecurityGroupName
        [in]  Duration KeyLifetime
        [in]  String SecurityPolicyUri
        [in]  UInt32 MaxFutureKeyCount
        [in]  UInt32 MaxPastKeyCount
        [in]  String SecurityGroupId
        [in]  NodeId SecurityGroupNodeId
    );
```

|Argument|Description|
|---|---|
|SecurityGroupName||
|KeyLifetime||
|SecurityPolicyUri||
|MaxFutureKeyCount||
|MaxPastKeyCount||
|SecurityGroupId||
|SecurityGroupNodeId||

### <a name="RemoveSecurityGroup"></a>RemoveSecurityGroup
  
**Signature**
```
    RemoveSecurityGroup(
        [in]  NodeId SecurityGroupNodeId
    );
```

|Argument|Description|
|---|---|
|SecurityGroupNodeId||


