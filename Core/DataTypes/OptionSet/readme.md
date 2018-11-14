<!-- datatype -->
## OptionSet
This abstract Structured DataType is the base DataType for all DataTypes representing a bit mask.  
<!-- end of description -->
The fields of the OptionSet DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|OptionSet|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;value|[ByteString](../../DataTypes/ByteString/readme.md)|Array of bytes representing the bits in the option set.|
|&nbsp;&nbsp;&nbsp;&nbsp;validBits|[ByteString](../../DataTypes/ByteString/readme.md)|Array of bytes with same size as value representing the valid bits in the value parameter.|

The representation of the OptionSet DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=12755|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|OptionSet|
|IsAbstract|False|
|BaseType|[Structure](../../DataTypes/Structure/readme.md)|
|Categories||

