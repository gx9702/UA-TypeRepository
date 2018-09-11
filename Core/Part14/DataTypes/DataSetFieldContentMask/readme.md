<!-- datatype -->
## DataSetFieldContentMask
The parameter DataSetFieldContentMask with DataType DataSetFieldContentMask indicates the fields of a DataValue included in the DataSetMessages. 

The DataSetFieldContentMask DataType is defined in 6.2.3.2.  
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
|BaseType|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)|
|Categories|Part14|

The references from the DataSetFieldContentMask DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|OptionSetValues|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

