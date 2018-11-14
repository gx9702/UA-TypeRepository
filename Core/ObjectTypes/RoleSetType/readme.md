<!-- objecttype -->
## RoleSetType
A container for the roles supported by the server.  
<!-- end of text -->
The representation of the RoleSetType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15607|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|RoleSetType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[BaseObjectType](../../ObjectTypes/BaseObjectType/readme.md)|
|Categories||

The references from the RoleSetType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[&lt;RoleName&gt;](#&lt;RoleName&gt;)||[RoleType](../../ObjectTypes/RoleType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[AddRole](#AddRole)|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[RemoveRole](#RemoveRole)|||[Mandatory](../../Objects/Mandatory/readme.md)|

### <a name="AddRole"></a>AddRole
  
**Signature**
```
    AddRole(
        [in]  String RoleName
        [in]  String NamespaceUri
        [in]  NodeId RoleNodeId
    );
```

|Argument|Description|
|---|---|
|RoleName||
|NamespaceUri||
|RoleNodeId||

### <a name="RemoveRole"></a>RemoveRole
  
**Signature**
```
    RemoveRole(
        [in]  NodeId RoleNodeId
    );
```

|Argument|Description|
|---|---|
|RoleNodeId||


