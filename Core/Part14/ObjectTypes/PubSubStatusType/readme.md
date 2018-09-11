<!-- objecttype -->
## PubSubStatusType
This ObjectType is used to indicate and change the status of a PubSub Object like PubSubConnection, DataSetWriter or DataSetReader. The PubSubStatusType is formally defined in Table 132.  
<!-- end of text -->
The representation of the PubSubStatusType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=14643|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|PubSubStatusType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[BaseObjectType](../../../Part5/ObjectTypes/BaseObjectType/readme.md)|
|Categories|Part14|

The references from the PubSubStatusType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[State](#State)|[PubSubState](../../../Part14/DataTypes/PubSubState/readme.md)|[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[Enable](#Enable)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[Disable](#Disable)|||[Optional](../../Objects/Optional/readme.md)|

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

