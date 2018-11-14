<!-- datatype -->
## DataSetFieldContentMask
  
<!-- end of description -->
The fields of the DataSetFieldContentMask DataType are defined in the following table:  

|Name|Bit No.| Description|
|---|---|---|
|StatusCode|0||
|SourceTimestamp|1||
|ServerTimestamp|2||
|SourcePicoSeconds|3||
|ServerPicoSeconds|4||
|RawDataEncoding|5||

The representation of the DataSetFieldContentMask DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15583|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|DataSetFieldContentMask|
|IsAbstract|False|
|BaseType|[UInt32](../../DataTypes/UInt32/readme.md)|
|Categories||

The references from the DataSetFieldContentMask DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|OptionSetValues|[LocalizedText](../../DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

