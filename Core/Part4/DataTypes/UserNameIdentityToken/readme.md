<!-- datatype -->
## UserNameIdentityToken
<!-- end of description -->
The fields of the UserNameIdentityToken DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|UserNameIdentityToken|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;userName|[String](../../../Part3/DataTypes/String/readme.md)|The user name.|
|&nbsp;&nbsp;&nbsp;&nbsp;password|[ByteString](../../../Part3/DataTypes/ByteString/readme.md)|The password encrypted with the server certificate.|
|&nbsp;&nbsp;&nbsp;&nbsp;encryptionAlgorithm|[String](../../../Part3/DataTypes/String/readme.md)|The algorithm used to encrypt the password.|

The representation of the UserNameIdentityToken DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|UserNameIdentityToken|
|IsAbtract|False|
|BaseType|[UserIdentityToken](../../../Part4/DataTypes/UserIdentityToken/readme.md)|

