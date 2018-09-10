<!-- objecttype -->
## BrokerWriterGroupTransportType
The representation of the BrokerWriterGroupTransportType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|BrokerWriterGroupTransportType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[WriterGroupTransportType](../../../Part14/ObjectTypes/WriterGroupTransportType/readme.md)|

The references from the BrokerWriterGroupTransportType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|QueueName|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|ResourceUri|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|AuthenticationProfileUri|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|RequestedDeliveryGuarantee|[BrokerTransportQualityOfService](../../../Part14/DataTypes/BrokerTransportQualityOfService/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

