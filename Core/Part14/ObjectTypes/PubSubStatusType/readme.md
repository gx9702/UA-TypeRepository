<!-- objecttype -->
## PubSubStatusType
The representation of the PubSubStatusType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|PubSubStatusType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[BaseObjectType](../../../Part5/ObjectTypes/BaseObjectType/readme.md)|

The references from the PubSubStatusType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|State||[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|Enable|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|Disable|||[Optional](../../Objects/Optional/readme.md)|

