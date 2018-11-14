<!-- datatype -->
## UserNameIdentityToken
A token representing a user identified by a user name and password.  
<!-- end of description -->
The fields of the UserNameIdentityToken DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|UserNameIdentityToken|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;userName|[String](../../DataTypes/String/readme.md)|The user name.|
|&nbsp;&nbsp;&nbsp;&nbsp;password|[ByteString](../../DataTypes/ByteString/readme.md)|The password encrypted with the server certificate.|
|&nbsp;&nbsp;&nbsp;&nbsp;encryptionAlgorithm|[String](../../DataTypes/String/readme.md)|The algorithm used to encrypt the password.|

The representation of the UserNameIdentityToken DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=322|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|UserNameIdentityToken|
|IsAbstract|False|
|BaseType|[UserIdentityToken](../../DataTypes/UserIdentityToken/readme.md)|
|Categories||

