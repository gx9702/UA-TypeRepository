<!-- datatype -->
## TrustListMasks
  
<!-- end of description -->
The fields of the TrustListMasks DataType are defined in the following table:  

|Name|Value| Description|
|---|---|---|
|None|0||
|TrustedCertificates|1||
|TrustedCrls|2||
|IssuerCertificates|4||
|IssuerCrls|8||
|All|15||

The representation of the TrustListMasks DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=12552|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|TrustListMasks|
|IsAbstract|False|
|BaseType|[Enumeration](../../DataTypes/Enumeration/readme.md)|
|Categories||

The references from the TrustListMasks DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|EnumValues|[EnumValueType](../../DataTypes/EnumValueType/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

