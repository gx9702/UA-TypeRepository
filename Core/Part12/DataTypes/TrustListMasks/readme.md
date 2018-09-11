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
|BaseType|[Enumeration](../../../Part3/DataTypes/Enumeration/readme.md)|
|Categories|Part12|

The references from the TrustListMasks DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|EnumValues|[EnumValueType](../../../Part3/DataTypes/EnumValueType/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

