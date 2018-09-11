<!-- objecttype -->
## BrokerDataSetWriterTransportType
This ObjectType represents broker transport protocol mapping specific parameters for a DataSetWriter. The BrokerDataSetWriterTransportType is formally defined in Table 168.  
<!-- end of text -->
The representation of the BrokerDataSetWriterTransportType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=21138|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|BrokerDataSetWriterTransportType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[DataSetWriterTransportType](../../../Part14/ObjectTypes/DataSetWriterTransportType/readme.md)|
|Categories|Part14|

The references from the BrokerDataSetWriterTransportType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[QueueName](#QueueName)|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[MetaDataQueueName](#MetaDataQueueName)|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ResourceUri](#ResourceUri)|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[AuthenticationProfileUri](#AuthenticationProfileUri)|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[RequestedDeliveryGuarantee](#RequestedDeliveryGuarantee)|[BrokerTransportQualityOfService](../../../Part14/DataTypes/BrokerTransportQualityOfService/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[MetaDataUpdateTime](#MetaDataUpdateTime)|[Duration](../../../Part3/DataTypes/Duration/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


