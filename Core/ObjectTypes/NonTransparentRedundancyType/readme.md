<!-- objecttype -->
## NonTransparentRedundancyType
Identifies the capabilties of server that supports non-transparent redundancy.  
<!-- end of text -->
The representation of the NonTransparentRedundancyType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2039|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|NonTransparentRedundancyType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[ServerRedundancyType](../../ObjectTypes/ServerRedundancyType/readme.md)|
|Categories||

The references from the NonTransparentRedundancyType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ServerUriArray](#ServerUriArray)|[String](../../DataTypes/String/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[NonTransparentNetworkRedundancyType](#NonTransparentNetworkRedundancyType)||||


