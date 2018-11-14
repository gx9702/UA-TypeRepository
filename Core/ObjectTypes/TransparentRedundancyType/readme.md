<!-- objecttype -->
## TransparentRedundancyType
Identifies the capabilties of server that supports transparent redundancy.  
<!-- end of text -->
The representation of the TransparentRedundancyType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2036|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|TransparentRedundancyType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[ServerRedundancyType](../../ObjectTypes/ServerRedundancyType/readme.md)|
|Categories||

The references from the TransparentRedundancyType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[CurrentServerId](#CurrentServerId)|[String](../../DataTypes/String/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[RedundantServerArray](#RedundantServerArray)|[RedundantServerDataType](../../DataTypes/RedundantServerDataType/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


