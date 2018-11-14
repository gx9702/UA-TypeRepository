<!-- datatype -->
## SignedSoftwareCertificate
A software certificate with a digital signature.  
<!-- end of description -->
The fields of the SignedSoftwareCertificate DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|SignedSoftwareCertificate|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;certificateData|[ByteString](../../DataTypes/ByteString/readme.md)|The data of the certificate.|
|&nbsp;&nbsp;&nbsp;&nbsp;signature|[ByteString](../../DataTypes/ByteString/readme.md)|The digital signature.|

The representation of the SignedSoftwareCertificate DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=344|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|SignedSoftwareCertificate|
|IsAbstract|False|
|BaseType|[Structure](../../DataTypes/Structure/readme.md)|
|Categories||

