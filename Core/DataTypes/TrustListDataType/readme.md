<!-- datatype -->
## TrustListDataType
  
<!-- end of description -->
The fields of the TrustListDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|TrustListDataType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;specifiedLists|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;trustedCertificates|[ByteString](../../DataTypes/ByteString/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;trustedCrls|[ByteString](../../DataTypes/ByteString/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;issuerCertificates|[ByteString](../../DataTypes/ByteString/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;issuerCrls|[ByteString](../../DataTypes/ByteString/readme.md)[]||

The representation of the TrustListDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=12554|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|TrustListDataType|
|IsAbstract|False|
|BaseType|[Structure](../../DataTypes/Structure/readme.md)|
|Categories||

