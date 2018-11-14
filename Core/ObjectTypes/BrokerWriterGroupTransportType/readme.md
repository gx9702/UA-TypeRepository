<!-- objecttype -->
## BrokerWriterGroupTransportType
  
<!-- end of text -->
The representation of the BrokerWriterGroupTransportType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=21136|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|BrokerWriterGroupTransportType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[WriterGroupTransportType](../../ObjectTypes/WriterGroupTransportType/readme.md)|
|Categories||

The references from the BrokerWriterGroupTransportType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[QueueName](#QueueName)|[String](../../DataTypes/String/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ResourceUri](#ResourceUri)|[String](../../DataTypes/String/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[AuthenticationProfileUri](#AuthenticationProfileUri)|[String](../../DataTypes/String/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[RequestedDeliveryGuarantee](#RequestedDeliveryGuarantee)|[BrokerTransportQualityOfService](../../DataTypes/BrokerTransportQualityOfService/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


