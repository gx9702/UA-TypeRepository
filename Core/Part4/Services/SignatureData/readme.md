<!-- datatype -->
## SignatureData
A digital signature.  
<!-- end of description -->
The fields of the SignatureData DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|SignatureData|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;algorithm|[String](../../../Part3/DataTypes/String/readme.md)|The cryptography algorithm used to create the signature.|
|&nbsp;&nbsp;&nbsp;&nbsp;signature|[ByteString](../../../Part3/DataTypes/ByteString/readme.md)|The signature.|

The representation of the SignatureData DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|SignatureData|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

