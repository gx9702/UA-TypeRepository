<!-- objecttype -->
## CertificateExpirationAlarmType
  
<!-- end of text -->
The representation of the CertificateExpirationAlarmType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=13225|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|CertificateExpirationAlarmType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[SystemOffNormalAlarmType](../../ObjectTypes/SystemOffNormalAlarmType/readme.md)|
|Categories||

The references from the CertificateExpirationAlarmType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ExpirationDate](#ExpirationDate)|[DateTime](../../DataTypes/DateTime/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ExpirationLimit](#ExpirationLimit)|[Duration](../../DataTypes/Duration/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[CertificateType](#CertificateType)|[NodeId](../../DataTypes/NodeId/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[Certificate](#Certificate)|[ByteString](../../DataTypes/ByteString/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


