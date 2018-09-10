<!-- objecttype -->
## SecurityGroupFolderType
  
The representation of the SecurityGroupFolderType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|SecurityGroupFolderType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[FolderType](../../../Part5/ObjectTypes/FolderType/readme.md)|

The references from the SecurityGroupFolderType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[Organizes](../../../Part3/ReferenceTypes/Organizes/readme.md)|Object|[&lt;SecurityGroupFolderName&gt;](#&lt;SecurityGroupFolderName&gt;)||[SecurityGroupFolderType](../../Part14/ObjectTypes/SecurityGroupFolderType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[&lt;SecurityGroupName&gt;](#&lt;SecurityGroupName&gt;)||[SecurityGroupType](../../Part14/ObjectTypes/SecurityGroupType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[AddSecurityGroup](#AddSecurityGroup)|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[RemoveSecurityGroup](#RemoveSecurityGroup)|||[Mandatory](../../Objects/Mandatory/readme.md)|

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


