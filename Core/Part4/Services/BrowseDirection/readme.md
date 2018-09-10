<!-- datatype -->
## BrowseDirection
<!-- end of description -->
The fields of the BrowseDirection DataType are defined in the following table:  

|Name|Value| Description|
|---|---|---|
|Forward|0|Return forward references.|
|Inverse|1|Return inverse references.|
|Both|2|Return forward and inverse references.|
|Invalid|3||

The representation of the BrowseDirection DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|BrowseDirection|
|IsAbtract|False|
|BaseType|[Enumeration](../../../Part3/DataTypes/Enumeration/readme.md)|

The references from the BrowseDirection DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|EnumStrings|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

