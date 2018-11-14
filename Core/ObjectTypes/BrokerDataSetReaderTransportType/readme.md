<!-- objecttype -->
## BrokerDataSetReaderTransportType
  
<!-- end of text -->
The representation of the BrokerDataSetReaderTransportType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=21142|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|BrokerDataSetReaderTransportType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[DataSetReaderTransportType](../../ObjectTypes/DataSetReaderTransportType/readme.md)|
|Categories||

The references from the BrokerDataSetReaderTransportType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[QueueName](#QueueName)|[String](../../DataTypes/String/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ResourceUri](#ResourceUri)|[String](../../DataTypes/String/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[AuthenticationProfileUri](#AuthenticationProfileUri)|[String](../../DataTypes/String/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[RequestedDeliveryGuarantee](#RequestedDeliveryGuarantee)|[BrokerTransportQualityOfService](../../DataTypes/BrokerTransportQualityOfService/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[MetaDataQueueName](#MetaDataQueueName)|[String](../../DataTypes/String/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


