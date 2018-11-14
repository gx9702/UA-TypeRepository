<!-- objecttype -->
## ConditionType
  
<!-- end of text -->
The representation of the ConditionType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2782|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|ConditionType|
|NodeClass|ObjectType|
|IsAbstract|True|
|BaseType|[BaseEventType](../../ObjectTypes/BaseEventType/readme.md)|
|Categories||

The references from the ConditionType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ConditionClassId](#ConditionClassId)|[NodeId](../../DataTypes/NodeId/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ConditionClassName](#ConditionClassName)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ConditionSubClassId](#ConditionSubClassId)|[NodeId](../../DataTypes/NodeId/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ConditionSubClassName](#ConditionSubClassName)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ConditionName](#ConditionName)|[String](../../DataTypes/String/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[BranchId](#BranchId)|[NodeId](../../DataTypes/NodeId/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[Retain](#Retain)|[Boolean](../../DataTypes/Boolean/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[EnabledState](#EnabledState)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|[TwoStateVariableType](../../VariableTypes/TwoStateVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[Quality](#Quality)|[StatusCode](../../DataTypes/StatusCode/readme.md)|[ConditionVariableType](../../VariableTypes/ConditionVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[LastSeverity](#LastSeverity)|[UInt16](../../DataTypes/UInt16/readme.md)|[ConditionVariableType](../../VariableTypes/ConditionVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[Comment](#Comment)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|[ConditionVariableType](../../VariableTypes/ConditionVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ClientUserId](#ClientUserId)|[String](../../DataTypes/String/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[Disable](#Disable)|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[Enable](#Enable)|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[AddComment](#AddComment)|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[ConditionRefresh](#ConditionRefresh)||||
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[ConditionRefresh2](#ConditionRefresh2)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[DialogConditionType](#DialogConditionType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AcknowledgeableConditionType](#AcknowledgeableConditionType)||||

### <a name="Disable"></a>Disable
  
**Signature**
```
    Disable(    );
```
### <a name="Enable"></a>Enable
  
**Signature**
```
    Enable(    );
```
### <a name="AddComment"></a>AddComment
  
**Signature**
```
    AddComment(
        [in]  ByteString EventId
        [in]  LocalizedText Comment
    );
```

|Argument|Description|
|---|---|
|EventId|The identifier for the event to comment.|
|Comment|The comment to add to the condition.|

### <a name="ConditionRefresh"></a>ConditionRefresh
  
**Signature**
```
    ConditionRefresh(
        [in]  IntegerId SubscriptionId
    );
```

|Argument|Description|
|---|---|
|SubscriptionId|The identifier for the suscription to refresh.|

### <a name="ConditionRefresh2"></a>ConditionRefresh2
  
**Signature**
```
    ConditionRefresh2(
        [in]  IntegerId SubscriptionId
        [in]  IntegerId MonitoredItemId
    );
```

|Argument|Description|
|---|---|
|SubscriptionId|The identifier for the suscription to refresh.|
|MonitoredItemId|The identifier for the monitored item to refresh.|


