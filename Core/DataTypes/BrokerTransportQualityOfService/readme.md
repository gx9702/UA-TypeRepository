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
|NodeId|i=15008|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|BrokerTransportQualityOfService|
|IsAbstract|False|
|BaseType|[Enumeration](../../DataTypes/Enumeration/readme.md)|
|Categories||

The references from the BrokerTransportQualityOfService DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|EnumStrings|[LocalizedText](../../DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

