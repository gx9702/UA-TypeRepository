<!-- objecttype -->
## BrokerWriterGroupTransportType
This ObjectType represents broker transport protocol mapping specific parameters for a WriterGroup. The BrokerWriterGroupTransportType is formally defined in Table 167.  
<!-- end of text -->
The representation of the BrokerWriterGroupTransportType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=21136|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|BrokerWriterGroupTransportType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[WriterGroupTransportType](../../../Part14/ObjectTypes/WriterGroupTransportType/readme.md)|
|Categories|Part14|

The references from the BrokerWriterGroupTransportType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[QueueName](#QueueName)|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ResourceUri](#ResourceUri)|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[AuthenticationProfileUri](#AuthenticationProfileUri)|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[RequestedDeliveryGuarantee](#RequestedDeliveryGuarantee)|[BrokerTransportQualityOfService](../../../Part14/DataTypes/BrokerTransportQualityOfService/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


