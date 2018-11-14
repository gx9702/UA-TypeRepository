<!-- objecttype -->
## PublishedEventsType
  
<!-- end of text -->
The representation of the PublishedEventsType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=14572|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|PublishedEventsType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[PublishedDataSetType](../../ObjectTypes/PublishedDataSetType/readme.md)|
|Categories||

The references from the PublishedEventsType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[EventNotifier](#EventNotifier)|[NodeId](../../DataTypes/NodeId/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[SelectedFields](#SelectedFields)|[SimpleAttributeOperand](../../DataTypes/SimpleAttributeOperand/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[Filter](#Filter)|[ContentFilter](../../DataTypes/ContentFilter/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[ModifyFieldSelection](#ModifyFieldSelection)|||[Optional](../../Objects/Optional/readme.md)|

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


