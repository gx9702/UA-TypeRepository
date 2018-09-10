<!-- objecttype -->
## PublishedDataItemsType

The representation of the PublishedDataItemsType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|PublishedDataItemsType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[PublishedDataSetType](../../../Part14/ObjectTypes/PublishedDataSetType/readme.md)|

The references from the PublishedDataItemsType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[PublishedData](#PublishedData)|[PublishedVariableDataType](../../../Part14/DataTypes/PublishedVariableDataType/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[AddVariables](#AddVariables)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[RemoveVariables](#RemoveVariables)|||[Optional](../../Objects/Optional/readme.md)|

### <a name="AddVariables"></a>AddVariables

**Signature**
```
    AddVariables(
        [in]  ConfigurationVersionDataType ConfigurationVersion
        [in]  String FieldNameAliases
        [in]  Boolean PromotedFields
        [in]  PublishedVariableDataType VariablesToAdd
        [in]  ConfigurationVersionDataType NewConfigurationVersion
        [in]  StatusCode AddResults
    );
```

|Argument|Description|
|---|---|
|ConfigurationVersion||
|FieldNameAliases||
|PromotedFields||
|VariablesToAdd||
|NewConfigurationVersion||
|AddResults||

### <a name="RemoveVariables"></a>RemoveVariables

**Signature**
```
    RemoveVariables(
        [in]  ConfigurationVersionDataType ConfigurationVersion
        [in]  UInt32 VariablesToRemove
        [in]  ConfigurationVersionDataType NewConfigurationVersion
        [in]  StatusCode RemoveResults
    );
```

|Argument|Description|
|---|---|
|ConfigurationVersion||
|VariablesToRemove||
|NewConfigurationVersion||
|RemoveResults||


