<!-- objecttype -->
## BrokerConnectionTransportType
This ObjectType represents broker transport protocol mapping specific parameters for a PubSubConnection. The BrokerConnectionTransportType is formally defined in Table 166.  
<!-- end of text -->
The representation of the BrokerConnectionTransportType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15155|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|BrokerConnectionTransportType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[ConnectionTransportType](../../../Part14/ObjectTypes/ConnectionTransportType/readme.md)|
|Categories|Part14|

The references from the BrokerConnectionTransportType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ResourceUri](#ResourceUri)|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[AuthenticationProfileUri](#AuthenticationProfileUri)|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


