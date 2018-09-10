<!-- objecttype -->
## TargetVariablesType
  
The representation of the TargetVariablesType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|TargetVariablesType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[SubscribedDataSetType](../../../Part14/ObjectTypes/SubscribedDataSetType/readme.md)|

The references from the TargetVariablesType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[TargetVariables](#TargetVariables)|[FieldTargetDataType](../../../Part14/DataTypes/FieldTargetDataType/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[AddTargetVariables](#AddTargetVariables)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[RemoveTargetVariables](#RemoveTargetVariables)|||[Optional](../../Objects/Optional/readme.md)|

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


