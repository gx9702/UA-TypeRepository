<!-- objecttype -->
## SecurityGroupFolderType
The representation of the SecurityGroupFolderType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|SecurityGroupFolderType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[FolderType](../../../Part5/ObjectTypes/FolderType/readme.md)|

The references from the SecurityGroupFolderType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[Organizes](../../../Part3/ReferenceTypes/Organizes/readme.md)|Object|&lt;SecurityGroupFolderName&gt;||[SecurityGroupFolderType](../../Part14/ObjectTypes/SecurityGroupFolderType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|&lt;SecurityGroupName&gt;||[SecurityGroupType](../../Part14/ObjectTypes/SecurityGroupType/readme.md)|[OptionalPlaceholder](../../Objects/OptionalPlaceholder/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|AddSecurityGroup|||[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|RemoveSecurityGroup|||[Mandatory](../../Objects/Mandatory/readme.md)|

