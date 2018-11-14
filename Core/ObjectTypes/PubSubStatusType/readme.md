<!-- objecttype -->
## PubSubStatusType
  
<!-- end of text -->
The representation of the PubSubStatusType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=14643|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|PubSubStatusType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[BaseObjectType](../../ObjectTypes/BaseObjectType/readme.md)|
|Categories||

The references from the PubSubStatusType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[State](#State)|[PubSubState](../../DataTypes/PubSubState/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[Enable](#Enable)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[Disable](#Disable)|||[Optional](../../Objects/Optional/readme.md)|

### <a name="Enable"></a>Enable
  
**Signature**
```
    Enable(    );
```
### <a name="Disable"></a>Disable
  
**Signature**
```
    Disable(    );
```

