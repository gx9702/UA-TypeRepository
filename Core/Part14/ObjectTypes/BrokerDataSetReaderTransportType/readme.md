<!-- objecttype -->
## BrokerDataSetReaderTransportType
This ObjectType represents datagram transport protocol mapping specific parameters for a DataSetReader. The BrokerDataSetReaderTransportType is formally defined in Table 170.  
<!-- end of text -->
The representation of the BrokerDataSetReaderTransportType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=21142|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|BrokerDataSetReaderTransportType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[DataSetReaderTransportType](../../../Part14/ObjectTypes/DataSetReaderTransportType/readme.md)|
|Categories|Part14|

The references from the BrokerDataSetReaderTransportType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[QueueName](#QueueName)|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ResourceUri](#ResourceUri)|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[AuthenticationProfileUri](#AuthenticationProfileUri)|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[RequestedDeliveryGuarantee](#RequestedDeliveryGuarantee)|[BrokerTransportQualityOfService](../../../Part14/DataTypes/BrokerTransportQualityOfService/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[MetaDataQueueName](#MetaDataQueueName)|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


