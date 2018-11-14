<!-- objecttype -->
## RoleType
  
<!-- end of text -->
The representation of the RoleType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15620|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|RoleType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[BaseObjectType](../../ObjectTypes/BaseObjectType/readme.md)|
|Categories||

The references from the RoleType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[Identities](#Identities)|[IdentityMappingRuleType](../../DataTypes/IdentityMappingRuleType/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[Applications](#Applications)|[String](../../DataTypes/String/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ApplicationsExclude](#ApplicationsExclude)|[Boolean](../../DataTypes/Boolean/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[Endpoints](#Endpoints)|[EndpointType](../../DataTypes/EndpointType/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[EndpointsExclude](#EndpointsExclude)|[Boolean](../../DataTypes/Boolean/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[AddIdentity](#AddIdentity)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[RemoveIdentity](#RemoveIdentity)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[AddApplication](#AddApplication)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[RemoveApplication](#RemoveApplication)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[AddEndpoint](#AddEndpoint)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[RemoveEndpoint](#RemoveEndpoint)|||[Optional](../../Objects/Optional/readme.md)|

### <a name="AddIdentity"></a>AddIdentity
  
**Signature**
```
    AddIdentity(
        [in]  IdentityMappingRuleType Rule
    );
```

|Argument|Description|
|---|---|
|Rule||

### <a name="RemoveIdentity"></a>RemoveIdentity
  
**Signature**
```
    RemoveIdentity(
        [in]  IdentityMappingRuleType Rule
    );
```

|Argument|Description|
|---|---|
|Rule||

### <a name="AddApplication"></a>AddApplication
  
**Signature**
```
    AddApplication(
        [in]  String ApplicationUri
    );
```

|Argument|Description|
|---|---|
|ApplicationUri||

### <a name="RemoveApplication"></a>RemoveApplication
  
**Signature**
```
    RemoveApplication(
        [in]  String ApplicationUri
    );
```

|Argument|Description|
|---|---|
|ApplicationUri||

### <a name="AddEndpoint"></a>AddEndpoint
  
**Signature**
```
    AddEndpoint(
        [in]  String Endpoint
    );
```

|Argument|Description|
|---|---|
|Endpoint||

### <a name="RemoveEndpoint"></a>RemoveEndpoint
  
**Signature**
```
    RemoveEndpoint(
        [in]  String Endpoint
    );
```

|Argument|Description|
|---|---|
|Endpoint||


