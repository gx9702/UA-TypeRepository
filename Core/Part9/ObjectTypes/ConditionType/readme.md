<!-- objecttype -->
## ConditionType
  
The representation of the ConditionType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|ConditionType|
|NodeClass|ObjectType|
|IsAbtract|True|
|BaseType|[BaseEventType](../../../Part5/ObjectTypes/BaseEventType/readme.md)|

The references from the ConditionType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ConditionClassId](#ConditionClassId)|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ConditionClassName](#ConditionClassName)|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ConditionSubClassId](#ConditionSubClassId)|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ConditionSubClassName](#ConditionSubClassName)|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ConditionName](#ConditionName)|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[BranchId](#BranchId)|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[Retain](#Retain)|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[EnabledState](#EnabledState)|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)|[TwoStateVariableType](../../Part9/VariableTypes/TwoStateVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[Quality](#Quality)|[StatusCode](../../../Part4/DataTypes/StatusCode/readme.md)|[ConditionVariableType](../../Part9/VariableTypes/ConditionVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[LastSeverity](#LastSeverity)|[UInt16](../../../Part3/DataTypes/UInt16/readme.md)|[ConditionVariableType](../../Part9/VariableTypes/ConditionVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[Comment](#Comment)|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)|[ConditionVariableType](../../Part9/VariableTypes/ConditionVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ClientUserId](#ClientUserId)|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[Disable](#Disable)|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[Enable](#Enable)|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[AddComment](#AddComment)|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[ConditionRefresh](#ConditionRefresh)||||
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[ConditionRefresh2](#ConditionRefresh2)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[DialogConditionType](#DialogConditionType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AcknowledgeableConditionType](#AcknowledgeableConditionType)||||

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


