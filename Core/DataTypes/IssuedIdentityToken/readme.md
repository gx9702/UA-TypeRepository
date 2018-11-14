<!-- datatype -->
## IssuedIdentityToken
A token representing a user identified by a WS-Security XML token.  
<!-- end of description -->
The fields of the IssuedIdentityToken DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|IssuedIdentityToken|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;tokenData|[ByteString](../../DataTypes/ByteString/readme.md)|The XML token encrypted with the server certificate.|
|&nbsp;&nbsp;&nbsp;&nbsp;encryptionAlgorithm|[String](../../DataTypes/String/readme.md)|The algorithm used to encrypt the certificate.|

The representation of the IssuedIdentityToken DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=938|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|IssuedIdentityToken|
|IsAbstract|False|
|BaseType|[UserIdentityToken](../../DataTypes/UserIdentityToken/readme.md)|
|Categories||

