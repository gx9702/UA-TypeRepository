<!-- objecttype -->
## SubscribedDataSetType
  
The representation of the SubscribedDataSetType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|SubscribedDataSetType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[BaseObjectType](../../../Part5/ObjectTypes/BaseObjectType/readme.md)|

The references from the SubscribedDataSetType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[DataSetMetaData](#DataSetMetaData)|[DataSetMetaDataType](../../../Part14/DataTypes/DataSetMetaDataType/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[MessageReceiveTimeout](#MessageReceiveTimeout)|[Duration](../../../Part3/DataTypes/Duration/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[TargetVariablesType](#TargetVariablesType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[SubscribedDataSetMirrorType](#SubscribedDataSetMirrorType)||||


