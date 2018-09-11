<!-- objecttype -->
## ExtensionFieldsType
The ExtensionFieldsType is formally defined in Table 106. It allows the configuration of fields with values to be included in the DataSet in case the existing AddressSpace of the Publisher does not provide the necessary information.  
<!-- end of text -->
The representation of the ExtensionFieldsType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15489|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|ExtensionFieldsType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[BaseObjectType](../../../Part5/ObjectTypes/BaseObjectType/readme.md)|
|Categories|Part14|

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


