<!-- objecttype -->
## NamespaceMetadataType
Provides the metadata for a namespace used by the server.  
<!-- end of text -->
The representation of the NamespaceMetadataType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=11616|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|NamespaceMetadataType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[BaseObjectType](../../ObjectTypes/BaseObjectType/readme.md)|
|Categories||

The references from the NamespaceMetadataType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[NamespaceUri](#NamespaceUri)|[String](../../DataTypes/String/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[NamespaceVersion](#NamespaceVersion)|[String](../../DataTypes/String/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[NamespacePublicationDate](#NamespacePublicationDate)|[DateTime](../../DataTypes/DateTime/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[IsNamespaceSubset](#IsNamespaceSubset)|[Boolean](../../DataTypes/Boolean/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[StaticNodeIdTypes](#StaticNodeIdTypes)|[IdType](../../DataTypes/IdType/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[StaticNumericNodeIdRange](#StaticNumericNodeIdRange)|[NumericRange](../../DataTypes/NumericRange/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[StaticStringNodeIdPattern](#StaticStringNodeIdPattern)|[String](../../DataTypes/String/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[NamespaceFile](#NamespaceFile)||[AddressSpaceFileType](../../ObjectTypes/AddressSpaceFileType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[DefaultRolePermissions](#DefaultRolePermissions)|[RolePermissionType](../../DataTypes/RolePermissionType/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[DefaultUserRolePermissions](#DefaultUserRolePermissions)|[RolePermissionType](../../DataTypes/RolePermissionType/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[DefaultAccessRestrictions](#DefaultAccessRestrictions)|[UInt16](../../DataTypes/UInt16/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|


