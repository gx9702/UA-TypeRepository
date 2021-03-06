<!-- datatype -->
## UserIdentityToken
A base type for a user identity token.  
<!-- end of description -->
The fields of the UserIdentityToken DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|UserIdentityToken|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;policyId|[String](../../DataTypes/String/readme.md)|The policy id specified in a user token policy for the endpoint being used.|

The representation of the UserIdentityToken DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=316|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|UserIdentityToken|
|IsAbstract|True|
|BaseType|[Structure](../../DataTypes/Structure/readme.md)|
|Categories||

The references from the UserIdentityToken DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|DataType|AnonymousIdentityToken||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|DataType|UserNameIdentityToken||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|DataType|X509IdentityToken||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|DataType|IssuedIdentityToken||||

