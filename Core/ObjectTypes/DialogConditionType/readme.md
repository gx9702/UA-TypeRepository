<!-- objecttype -->
## DialogConditionType
  
<!-- end of text -->
The representation of the DialogConditionType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2830|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|DialogConditionType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[ConditionType](../../ObjectTypes/ConditionType/readme.md)|
|Categories||

The references from the DialogConditionType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[EnabledState](#EnabledState)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|[TwoStateVariableType](../../VariableTypes/TwoStateVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[DialogState](#DialogState)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|[TwoStateVariableType](../../VariableTypes/TwoStateVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[Prompt](#Prompt)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ResponseOptionSet](#ResponseOptionSet)|[LocalizedText](../../DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[DefaultResponse](#DefaultResponse)|[Int32](../../DataTypes/Int32/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[OkResponse](#OkResponse)|[Int32](../../DataTypes/Int32/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[CancelResponse](#CancelResponse)|[Int32](../../DataTypes/Int32/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[LastResponse](#LastResponse)|[Int32](../../DataTypes/Int32/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[Respond](#Respond)|||[Mandatory](../../Objects/Mandatory/readme.md)|

### <a name="Respond"></a>Respond
  
**Signature**
```
    Respond(
        [in]  Int32 SelectedResponse
    );
```

|Argument|Description|
|---|---|
|SelectedResponse|The response to the dialog condition.|


