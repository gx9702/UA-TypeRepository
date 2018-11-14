<!-- datatype -->
## PermissionType
  
<!-- end of description -->
The fields of the PermissionType DataType are defined in the following table:  

|Name|Bit No.| Description|
|---|---|---|
|Browse|0||
|ReadRolePermissions|1||
|WriteAttribute|2||
|WriteRolePermissions|3||
|WriteHistorizing|4||
|Read|5||
|Write|6||
|ReadHistory|7||
|InsertHistory|8||
|ModifyHistory|9||
|DeleteHistory|10||
|ReceiveEvents|11||
|Call|12||
|AddReference|13||
|RemoveReference|14||
|DeleteNode|15||
|AddNode|16||

The representation of the PermissionType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=94|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|PermissionType|
|IsAbstract|False|
|BaseType|[UInt32](../../DataTypes/UInt32/readme.md)|
|Categories||

The references from the PermissionType DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|OptionSetValues|[LocalizedText](../../DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

