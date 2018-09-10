<!-- datatype -->
## BrokerTransportQualityOfService
<!-- end of description -->
The fields of the BrokerTransportQualityOfService DataType are defined in the following table:  

|Name|Value| Description|
|---|---|---|
|NotSpecified|0||
|BestEffort|1||
|AtLeastOnce|2||
|AtMostOnce|3||
|ExactlyOnce|4||

The representation of the BrokerTransportQualityOfService DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|BrokerTransportQualityOfService|
|IsAbtract|False|
|BaseType|[Enumeration](../../../Part3/DataTypes/Enumeration/readme.md)|

The references from the BrokerTransportQualityOfService DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|EnumStrings|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

