<!-- objecttype -->
## PubSubStatusEventType
  
<!-- end of text -->
The representation of the PubSubStatusEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15535|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|PubSubStatusEventType|
|NodeClass|ObjectType|
|IsAbstract|True|
|BaseType|[SystemEventType](../../ObjectTypes/SystemEventType/readme.md)|
|Categories||

The references from the PubSubStatusEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ConnectionId](#ConnectionId)|[NodeId](../../DataTypes/NodeId/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[GroupId](#GroupId)|[NodeId](../../DataTypes/NodeId/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[State](#State)|[PubSubState](../../DataTypes/PubSubState/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[PubSubTransportLimitsExceedEventType](#PubSubTransportLimitsExceedEventType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[PubSubCommunicationFailureEventType](#PubSubCommunicationFailureEventType)||||


