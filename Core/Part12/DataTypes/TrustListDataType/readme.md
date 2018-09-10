<!-- datatype -->
## TrustListDataType
<!-- end of description -->
The fields of the TrustListDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|TrustListDataType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;specifiedLists|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;trustedCertificates|[ByteString](../../../Part3/DataTypes/ByteString/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;trustedCrls|[ByteString](../../../Part3/DataTypes/ByteString/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;issuerCertificates|[ByteString](../../../Part3/DataTypes/ByteString/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;issuerCrls|[ByteString](../../../Part3/DataTypes/ByteString/readme.md)[]||

The representation of the TrustListDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|TrustListDataType|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

