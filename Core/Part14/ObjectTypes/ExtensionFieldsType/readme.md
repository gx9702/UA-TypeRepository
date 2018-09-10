<!-- objecttype -->
## ExtensionFieldsType
  
The representation of the ExtensionFieldsType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|ExtensionFieldsType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[BaseObjectType](../../../Part5/ObjectTypes/BaseObjectType/readme.md)|

The references from the ExtensionFieldsType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[&lt;ExtensionFieldName&gt;](#&lt;ExtensionFieldName&gt;)|[BaseDataType](../../../Part3/DataTypes/BaseDataType/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[AddExtensionField](#AddExtensionField)|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[RemoveExtensionField](#RemoveExtensionField)|||[Mandatory](../../Objects/Mandatory/readme.md)|

### <a name="AddExtensionField"></a>AddExtensionField
  
**Signature**
```
    AddExtensionField(
        [in]  QualifiedName FieldName
        [in]  BaseDataType FieldValue
        [in]  NodeId FieldId
    );
```

|Argument|Description|
|---|---|
|FieldName||
|FieldValue||
|FieldId||

### <a name="RemoveExtensionField"></a>RemoveExtensionField
  
**Signature**
```
    RemoveExtensionField(
        [in]  NodeId FieldId
    );
```

|Argument|Description|
|---|---|
|FieldId||


