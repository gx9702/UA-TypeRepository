<!-- datatype -->
## X509IdentityToken
A token representing a user identified by an X509 certificate.  
<!-- end of description -->
The fields of the X509IdentityToken DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|X509IdentityToken|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;certificateData|[ByteString](../../DataTypes/ByteString/readme.md)|The certificate.|

The representation of the X509IdentityToken DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=325|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|X509IdentityToken|
|IsAbstract|False|
|BaseType|[UserIdentityToken](../../DataTypes/UserIdentityToken/readme.md)|
|Categories||

