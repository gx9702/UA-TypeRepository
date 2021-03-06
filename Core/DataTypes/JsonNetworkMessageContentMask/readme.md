<!-- datatype -->
## JsonNetworkMessageContentMask
  
<!-- end of description -->
The fields of the JsonNetworkMessageContentMask DataType are defined in the following table:  

|Name|Bit No.| Description|
|---|---|---|
|NetworkMessageHeader|0||
|DataSetMessageHeader|1||
|SingleDataSetMessage|2||
|PublisherId|3||
|DataSetClassId|4||
|ReplyTo|5||

The representation of the JsonNetworkMessageContentMask DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15654|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|JsonNetworkMessageContentMask|
|IsAbstract|False|
|BaseType|[UInt32](../../DataTypes/UInt32/readme.md)|
|Categories||

The references from the JsonNetworkMessageContentMask DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|OptionSetValues|[LocalizedText](../../DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

