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
|BaseType|[BaseObjectType](../../../Part5/ObjectTypes/BaseObjectType/readme.md)|
|Categories|Part5|

The references from the RoleType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[Identities](#Identities)|[IdentityMappingRuleType](../../../Part5/DataTypes/IdentityMappingRuleType/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[Applications](#Applications)|[String](../../../Part3/DataTypes/String/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ApplicationsExclude](#ApplicationsExclude)|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[Endpoints](#Endpoints)|[EndpointType](../../../Part5/DataTypes/EndpointType/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[EndpointsExclude](#EndpointsExclude)|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[AddIdentity](#AddIdentity)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[RemoveIdentity](#RemoveIdentity)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[AddApplication](#AddApplication)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[RemoveApplication](#RemoveApplication)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[AddEndpoint](#AddEndpoint)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[RemoveEndpoint](#RemoveEndpoint)|||[Optional](../../Objects/Optional/readme.md)|

### <a name="AddIdentity"></a>AddIdentity
  
**Signature**
```
    AddIdentity(
        [in]  IdentityMappingRuleType RuleToAdd
    );
```

|Argument|Description|
|---|---|
|RuleToAdd||

### <a name="RemoveIdentity"></a>RemoveIdentity
  
**Signature**
```
    RemoveIdentity(
        [in]  IdentityMappingRuleType RuleToRemove
    );
```

|Argument|Description|
|---|---|
|RuleToRemove||

### <a name="AddApplication"></a>AddApplication
  
**Signature**
```
    AddApplication(
        [in]  String RuleToAdd
    );
```

|Argument|Description|
|---|---|
|RuleToAdd||

### <a name="RemoveApplication"></a>RemoveApplication
  
**Signature**
```
    RemoveApplication(
        [in]  String RuleToRemove
    );
```

|Argument|Description|
|---|---|
|RuleToRemove||

### <a name="AddEndpoint"></a>AddEndpoint
  
**Signature**
```
    AddEndpoint(
        [in]  String RuleToAdd
    );
```

|Argument|Description|
|---|---|
|RuleToAdd||

### <a name="RemoveEndpoint"></a>RemoveEndpoint
  
**Signature**
```
    RemoveEndpoint(
        [in]  String RuleToRemove
    );
```

|Argument|Description|
|---|---|
|RuleToRemove||


