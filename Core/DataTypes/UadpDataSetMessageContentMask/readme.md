<!-- datatype -->
## UadpDataSetMessageContentMask
  
<!-- end of description -->
The fields of the UadpDataSetMessageContentMask DataType are defined in the following table:  

|Name|Bit No.| Description|
|---|---|---|
|Timestamp|0||
|PicoSeconds|1||
|Status|2||
|MajorVersion|3||
|MinorVersion|4||
|SequenceNumber|5||

The representation of the UadpDataSetMessageContentMask DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15646|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|UadpDataSetMessageContentMask|
|IsAbstract|False|
|BaseType|[UInt32](../../DataTypes/UInt32/readme.md)|
|Categories||

The references from the UadpDataSetMessageContentMask DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|OptionSetValues|[LocalizedText](../../DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

