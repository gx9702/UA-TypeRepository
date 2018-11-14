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
|BaseType|[ConditionType](../../ObjectTypes/ConditionType/readme.md)|
|Categories||

The references from the AcknowledgeableConditionType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[EnabledState](#EnabledState)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|[TwoStateVariableType](../../VariableTypes/TwoStateVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[AckedState](#AckedState)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|[TwoStateVariableType](../../VariableTypes/TwoStateVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[ConfirmedState](#ConfirmedState)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|[TwoStateVariableType](../../VariableTypes/TwoStateVariableType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[Acknowledge](#Acknowledge)|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[Confirm](#Confirm)|||[Optional](../../Objects/Optional/readme.md)|
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[AlarmConditionType](#AlarmConditionType)||||

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


