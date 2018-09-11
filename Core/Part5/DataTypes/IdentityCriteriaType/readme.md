<!-- datatype -->
## IdentityCriteriaType
  
<!-- end of description -->
The fields of the IdentityCriteriaType DataType are defined in the following table:  

|Name|Value| Description|
|---|---|---|
|UserName|1||
|Thumbprint|2||
|Role|3||
|GroupId|4||
|Anonymous|5||
|AuthenticatedUser|6||

The representation of the IdentityCriteriaType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15632|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|IdentityCriteriaType|
|IsAbstract|False|
|BaseType|[Enumeration](../../../Part3/DataTypes/Enumeration/readme.md)|
|Categories|Part5|

The references from the IdentityCriteriaType DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|EnumValues|[EnumValueType](../../../Part3/DataTypes/EnumValueType/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

