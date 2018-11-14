<!-- objecttype -->
## TargetVariablesType
  
<!-- end of text -->
The representation of the TargetVariablesType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15111|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|TargetVariablesType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[SubscribedDataSetType](../../ObjectTypes/SubscribedDataSetType/readme.md)|
|Categories||

The references from the TargetVariablesType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[TargetVariables](#TargetVariables)|[FieldTargetDataType](../../DataTypes/FieldTargetDataType/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[AddTargetVariables](#AddTargetVariables)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[RemoveTargetVariables](#RemoveTargetVariables)|||[Optional](../../Objects/Optional/readme.md)|

### <a name="AddTargetVariables"></a>AddTargetVariables
  
**Signature**
```
    AddTargetVariables(
        [in]  ConfigurationVersionDataType ConfigurationVersion
        [in]  FieldTargetDataType TargetVariablesToAdd
        [in]  StatusCode AddResults
    );
```

|Argument|Description|
|---|---|
|ConfigurationVersion||
|TargetVariablesToAdd||
|AddResults||

### <a name="RemoveTargetVariables"></a>RemoveTargetVariables
  
**Signature**
```
    RemoveTargetVariables(
        [in]  ConfigurationVersionDataType ConfigurationVersion
        [in]  UInt32 TargetsToRemove
        [in]  StatusCode RemoveResults
    );
```

|Argument|Description|
|---|---|
|ConfigurationVersion||
|TargetsToRemove||
|RemoveResults||


