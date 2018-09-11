<!-- objecttype -->
## PubSubCommunicationFailureEventType
This EventType indicates that a NetworkMessage could not be published because of a communication failure. The PubSubCommunicationFailureEventType is formally defined in Table 157.  
<!-- end of text -->
The representation of the PubSubCommunicationFailureEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15563|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|PubSubCommunicationFailureEventType|
|NodeClass|ObjectType|
|IsAbstract|True|
|BaseType|[PubSubStatusEventType](../../../Part14/ObjectTypes/PubSubStatusEventType/readme.md)|
|Categories|Part14|

The references from the PubSubCommunicationFailureEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[Error](#Error)|[StatusCode](../../../Part4/DataTypes/StatusCode/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


