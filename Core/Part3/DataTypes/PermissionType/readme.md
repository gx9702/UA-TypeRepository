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
|BaseType|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)|
|Categories|Part3|

The references from the PermissionType DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|OptionSetValues|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

