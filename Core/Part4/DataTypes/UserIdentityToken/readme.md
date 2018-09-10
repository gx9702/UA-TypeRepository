<!-- datatype -->
## UserIdentityToken
<!-- end of description -->
The fields of the UserIdentityToken DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|UserIdentityToken|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;policyId|[String](../../../Part3/DataTypes/String/readme.md)|The policy id specified in a user token policy for the endpoint being used.|

The representation of the UserIdentityToken DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|UserIdentityToken|
|IsAbtract|True|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

The references from the UserIdentityToken DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|AnonymousIdentityToken||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|UserNameIdentityToken||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|X509IdentityToken||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|IssuedIdentityToken||||

