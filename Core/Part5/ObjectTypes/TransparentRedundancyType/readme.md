<!-- objecttype -->
## TransparentRedundancyType
Identifies the capabilties of server that supports transparent redundancy.  
The representation of the TransparentRedundancyType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|TransparentRedundancyType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[ServerRedundancyType](../../../Part5/ObjectTypes/ServerRedundancyType/readme.md)|

The references from the TransparentRedundancyType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[CurrentServerId](#CurrentServerId)|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[RedundantServerArray](#RedundantServerArray)|[RedundantServerDataType](../../../Part5/DataTypes/RedundantServerDataType/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


