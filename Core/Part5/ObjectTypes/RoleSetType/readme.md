<!-- objecttype -->
## RoleSetType
The representation of the RoleSetType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|RoleSetType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[BaseObjectType](../../../Part5/ObjectTypes/BaseObjectType/readme.md)|

The references from the RoleSetType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|&lt;RoleName&gt;||[RoleType](../../Part5/ObjectTypes/RoleType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|AddRole|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|RemoveRole|||[Mandatory](../../Objects/Mandatory/readme.md)|

