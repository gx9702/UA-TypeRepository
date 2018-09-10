<!-- objecttype -->
## PubSubKeyServiceType
The representation of the PubSubKeyServiceType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|PubSubKeyServiceType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[BaseObjectType](../../../Part5/ObjectTypes/BaseObjectType/readme.md)|

The references from the PubSubKeyServiceType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|GetSecurityKeys|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|GetSecurityGroup|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|SecurityGroups||[SecurityGroupFolderType](../../Part14/ObjectTypes/SecurityGroupFolderType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|PublishSubscribeType||||

