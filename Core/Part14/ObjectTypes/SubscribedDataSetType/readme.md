<!-- objecttype -->
## SubscribedDataSetType
This ObjectType defines the metadata for the subscribed DataSet and the information for the processing of DataSetMessages. The SubscribedDataSetType is formally defined in Table 129.  
<!-- end of text -->
The representation of the SubscribedDataSetType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15108|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|SubscribedDataSetType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[BaseObjectType](../../../Part5/ObjectTypes/BaseObjectType/readme.md)|
|Categories|Part14|

The references from the SubscribedDataSetType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[DataSetMetaData](#DataSetMetaData)|[DataSetMetaDataType](../../../Part14/DataTypes/DataSetMetaDataType/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[MessageReceiveTimeout](#MessageReceiveTimeout)|[Duration](../../../Part3/DataTypes/Duration/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[TargetVariablesType](#TargetVariablesType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[SubscribedDataSetMirrorType](#SubscribedDataSetMirrorType)||||


