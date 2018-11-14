<!-- objecttype -->
## ServerRedundancyType
A base type for an object that describe how a server supports redundancy.  
<!-- end of text -->
The representation of the ServerRedundancyType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2034|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|ServerRedundancyType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[BaseObjectType](../../ObjectTypes/BaseObjectType/readme.md)|
|Categories||

The references from the ServerRedundancyType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[RedundancySupport](#RedundancySupport)|[RedundancySupport](../../DataTypes/RedundancySupport/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[TransparentRedundancyType](#TransparentRedundancyType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[NonTransparentRedundancyType](#NonTransparentRedundancyType)||||


