<!-- objecttype -->
## PubSubTransportLimitsExceedEventType
This EventType indicates that a NetworkMessage could not be published because it exceeds the limits of transport. The PubSubTransportLimitsExceedEventType is formally defined in Table 156.  
<!-- end of text -->
The representation of the PubSubTransportLimitsExceedEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15548|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|PubSubTransportLimitsExceedEventType|
|NodeClass|ObjectType|
|IsAbstract|True|
|BaseType|[PubSubStatusEventType](../../../Part14/ObjectTypes/PubSubStatusEventType/readme.md)|
|Categories|Part14|

The references from the PubSubTransportLimitsExceedEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[Actual](#Actual)|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[Maximum](#Maximum)|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


