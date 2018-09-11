<!-- datatype -->
## OverrideValueHandling
The OverrideValueHandling is an enumeration that specifies the possible options for the handling of Override values. The possible enumeration values are described in Table 45.  
<!-- end of description -->
The fields of the OverrideValueHandling DataType are defined in the following table:  

|Name|Value| Description|
|---|---|---|
|Disabled|0||
|LastUseableValue|1||
|OverrideValue|2||

The representation of the OverrideValueHandling DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15874|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|OverrideValueHandling|
|IsAbstract|False|
|BaseType|[Enumeration](../../../Part3/DataTypes/Enumeration/readme.md)|
|Categories|Part14|

The references from the OverrideValueHandling DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|EnumStrings|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

