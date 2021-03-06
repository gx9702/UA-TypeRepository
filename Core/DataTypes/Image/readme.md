<!-- datatype -->
## Image
Describes a value that is an image encoded as a string of bytes.  
<!-- end of description -->
The fields of the Image DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|Image|Structure||

The representation of the Image DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=30|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|Image|
|IsAbstract|True|
|BaseType|[ByteString](../../DataTypes/ByteString/readme.md)|
|Categories||

The references from the Image DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|DataType|ImageBMP||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|DataType|ImageGIF||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|DataType|ImageJPG||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|DataType|ImagePNG||||

