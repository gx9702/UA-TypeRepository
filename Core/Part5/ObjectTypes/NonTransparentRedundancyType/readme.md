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
|BaseType|[ServerRedundancyType](../../../Part5/ObjectTypes/ServerRedundancyType/readme.md)|
|Categories|Part5|

The references from the NonTransparentRedundancyType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ServerUriArray](#ServerUriArray)|[String](../../../Part3/DataTypes/String/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[NonTransparentNetworkRedundancyType](#NonTransparentNetworkRedundancyType)||||


