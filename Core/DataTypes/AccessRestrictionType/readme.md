<!-- datatype -->
## AccessRestrictionType
  
<!-- end of description -->
The fields of the AccessRestrictionType DataType are defined in the following table:  

|Name|Bit No.| Description|
|---|---|---|
|SigningRequired|0||
|EncryptionRequired|1||
|SessionRequired|2||

The representation of the AccessRestrictionType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=95|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|AccessRestrictionType|
|IsAbstract|False|
|BaseType|[UInt32](../../DataTypes/UInt32/readme.md)|
|Categories||

The references from the AccessRestrictionType DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|OptionSetValues|[LocalizedText](../../DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

