<!-- objecttype -->
## PublishedEventsType
This PublishedDataSetType is used to configure the collection of OPC UA Events.

The PublishedEventsType is formally defined in Table 110.  
<!-- end of text -->
The representation of the PublishedEventsType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=14572|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|PublishedEventsType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[PublishedDataSetType](../../../Part14/ObjectTypes/PublishedDataSetType/readme.md)|
|Categories|Part14|

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


