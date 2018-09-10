<!-- objecttype -->
## SystemEventType
The representation of the SystemEventType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|SystemEventType|
|NodeClass|ObjectType|
|IsAbtract|True|
|BaseType|[BaseEventType](../../../Part5/ObjectTypes/BaseEventType/readme.md)|

The references from the SystemEventType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|DeviceFailureEventType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|SystemStatusChangeEventType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|RefreshStartEventType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|RefreshEndEventType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|RefreshRequiredEventType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|PubSubStatusEventType||||

