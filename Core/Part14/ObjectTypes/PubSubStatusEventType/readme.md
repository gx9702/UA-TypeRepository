<!-- objecttype -->
## PubSubStatusEventType
This EventType is a base type for events which indicate an error or status change associated with a PubSubConnectionType, PubSubGroupType, DataSetWriterType or DataSetReaderType Object. The PubSubStatusEventType is formally defined in Table 155.  
<!-- end of text -->
The representation of the PubSubStatusEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15535|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|PubSubStatusEventType|
|NodeClass|ObjectType|
|IsAbstract|True|
|BaseType|[SystemEventType](../../../Part5/ObjectTypes/SystemEventType/readme.md)|
|Categories|Part14|

The references from the PubSubStatusEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ConnectionId](#ConnectionId)|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[GroupId](#GroupId)|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[State](#State)|[PubSubState](../../../Part14/DataTypes/PubSubState/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[PubSubTransportLimitsExceedEventType](#PubSubTransportLimitsExceedEventType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[PubSubCommunicationFailureEventType](#PubSubCommunicationFailureEventType)||||


