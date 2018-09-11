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
|BaseType|[BaseObjectType](../../../Part5/ObjectTypes/BaseObjectType/readme.md)|
|Categories|Part5|

The references from the NamespaceMetadataType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[NamespaceUri](#NamespaceUri)|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[NamespaceVersion](#NamespaceVersion)|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[NamespacePublicationDate](#NamespacePublicationDate)|[DateTime](../../../Part3/DataTypes/DateTime/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[IsNamespaceSubset](#IsNamespaceSubset)|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[StaticNodeIdTypes](#StaticNodeIdTypes)|[IdType](../../../Part3/DataTypes/IdType/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[StaticNumericNodeIdRange](#StaticNumericNodeIdRange)|[NumericRange](../../../Part4/DataTypes/NumericRange/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[StaticStringNodeIdPattern](#StaticStringNodeIdPattern)|[String](../../../Part3/DataTypes/String/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[NamespaceFile](#NamespaceFile)||[AddressSpaceFileType](../../Part5/ObjectTypes/AddressSpaceFileType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[DefaultRolePermissions](#DefaultRolePermissions)|[RolePermissionType](../../../Part3/DataTypes/RolePermissionType/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[DefaultUserRolePermissions](#DefaultUserRolePermissions)|[RolePermissionType](../../../Part3/DataTypes/RolePermissionType/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[DefaultAccessRestrictions](#DefaultAccessRestrictions)|[UInt16](../../../Part3/DataTypes/UInt16/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|


