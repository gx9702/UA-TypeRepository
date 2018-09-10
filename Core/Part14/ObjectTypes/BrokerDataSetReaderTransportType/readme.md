<!-- objecttype -->
## BrokerDataSetReaderTransportType
The representation of the BrokerDataSetReaderTransportType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|BrokerDataSetReaderTransportType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[DataSetReaderTransportType](../../../Part14/ObjectTypes/DataSetReaderTransportType/readme.md)|

The references from the BrokerDataSetReaderTransportType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|QueueName|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|ResourceUri|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|AuthenticationProfileUri|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|RequestedDeliveryGuarantee|[BrokerTransportQualityOfService](../../../Part14/DataTypes/BrokerTransportQualityOfService/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|MetaDataQueueName|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

