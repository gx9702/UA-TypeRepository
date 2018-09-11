<!-- objecttype -->
## AcknowledgeableConditionType
  
<!-- end of text -->
The representation of the AcknowledgeableConditionType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2881|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|AcknowledgeableConditionType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[ConditionType](../../../Part9/ObjectTypes/ConditionType/readme.md)|
|Categories|Part9|

The references from the AcknowledgeableConditionType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[EnabledState](#EnabledState)|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)|[TwoStateVariableType](../../Part9/VariableTypes/TwoStateVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[AckedState](#AckedState)|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)|[TwoStateVariableType](../../Part9/VariableTypes/TwoStateVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[ConfirmedState](#ConfirmedState)|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)|[TwoStateVariableType](../../Part9/VariableTypes/TwoStateVariableType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[Acknowledge](#Acknowledge)|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[Confirm](#Confirm)|||[Optional](../../Objects/Optional/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AlarmConditionType](#AlarmConditionType)||||

### <a name="Acknowledge"></a>Acknowledge
  
**Signature**
```
    Acknowledge(
        [in]  ByteString EventId
        [in]  LocalizedText Comment
    );
```

|Argument|Description|
|---|---|
|EventId|The identifier for the event to comment.|
|Comment|The comment to add to the condition.|

### <a name="Confirm"></a>Confirm
  
**Signature**
```
    Confirm(
        [in]  ByteString EventId
        [in]  LocalizedText Comment
    );
```

|Argument|Description|
|---|---|
|EventId|The identifier for the event to comment.|
|Comment|The comment to add to the condition.|


