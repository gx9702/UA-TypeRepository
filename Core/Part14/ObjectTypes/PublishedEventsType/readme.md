<!-- objecttype -->
## PublishedEventsType

The representation of the PublishedEventsType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|PublishedEventsType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[PublishedDataSetType](../../../Part14/ObjectTypes/PublishedDataSetType/readme.md)|

The references from the PublishedEventsType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[EventNotifier](#EventNotifier)|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[SelectedFields](#SelectedFields)|[SimpleAttributeOperand](../../../Part4/DataTypes/SimpleAttributeOperand/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[Filter](#Filter)|[ContentFilter](../../../Part4/DataTypes/ContentFilter/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[ModifyFieldSelection](#ModifyFieldSelection)|||[Optional](../../Objects/Optional/readme.md)|

### <a name="ModifyFieldSelection"></a>ModifyFieldSelection

**Signature**
```
    ModifyFieldSelection(
        [in]  ConfigurationVersionDataType ConfigurationVersion
        [in]  String FieldNameAliases
        [in]  Boolean PromotedFields
        [in]  SimpleAttributeOperand SelectedFields
        [in]  ConfigurationVersionDataType NewConfigurationVersion
    );
```

|Argument|Description|
|---|---|
|ConfigurationVersion||
|FieldNameAliases||
|PromotedFields||
|SelectedFields||
|NewConfigurationVersion||


