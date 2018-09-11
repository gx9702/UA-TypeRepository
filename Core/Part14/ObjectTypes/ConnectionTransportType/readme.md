<!-- objecttype -->
## ConnectionTransportType
This ObjectType is the abstract base type for Objects representing transport protocol mapping specific settings for PubSubConnections. The ConnectionTransportType is formally defined in Table 113.  
<!-- end of text -->
The representation of the ConnectionTransportType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=17721|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|ConnectionTransportType|
|NodeClass|ObjectType|
|IsAbstract|True|
|BaseType|[BaseObjectType](../../../Part5/ObjectTypes/BaseObjectType/readme.md)|
|Categories|Part14|

The references from the ConnectionTransportType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[DatagramConnectionTransportType](#DatagramConnectionTransportType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[BrokerConnectionTransportType](#BrokerConnectionTransportType)||||


