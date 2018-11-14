<!-- objecttype -->
## BrokerDataSetWriterTransportType
  
<!-- end of text -->
The representation of the BrokerDataSetWriterTransportType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=21138|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|BrokerDataSetWriterTransportType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[DataSetWriterTransportType](../../ObjectTypes/DataSetWriterTransportType/readme.md)|
|Categories||

The references from the BrokerDataSetWriterTransportType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[QueueName](#QueueName)|[String](../../DataTypes/String/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[MetaDataQueueName](#MetaDataQueueName)|[String](../../DataTypes/String/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ResourceUri](#ResourceUri)|[String](../../DataTypes/String/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[AuthenticationProfileUri](#AuthenticationProfileUri)|[String](../../DataTypes/String/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[RequestedDeliveryGuarantee](#RequestedDeliveryGuarantee)|[BrokerTransportQualityOfService](../../DataTypes/BrokerTransportQualityOfService/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[MetaDataUpdateTime](#MetaDataUpdateTime)|[Duration](../../DataTypes/Duration/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


