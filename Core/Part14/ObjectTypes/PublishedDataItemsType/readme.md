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
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|PublishedData|[PublishedVariableDataType](../../../Part14/DataTypes/PublishedVariableDataType/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|AddVariables|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|RemoveVariables|||[Optional](../../Objects/Optional/readme.md)|

