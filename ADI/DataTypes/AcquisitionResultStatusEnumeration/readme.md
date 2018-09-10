<!-- datatype -->
## AcquisitionResultStatusEnumeration
<!-- end of description -->
The fields of the AcquisitionResultStatusEnumeration DataType are defined in the following table:  

|Name|Value| Description|
|---|---|---|
|NOT_USED|0|No longer used.|
|GOOD|1|The acquisition has been completed as requested without any error.|
|BAD|2|The acquisition has been completed as requested with error.|
|UNKNOWN|3|The acquisition has been completed but nothing can be said about the quality of the result.|
|PARTIAL|4|The acquisition has been partially completed as requested without any error.|

The representation of the AcquisitionResultStatusEnumeration DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|AcquisitionResultStatusEnumeration|
|IsAbtract|False|
|BaseType|[Enumeration](../../../Core/Part3/DataTypes/Enumeration/readme.md)|

The references from the AcquisitionResultStatusEnumeration DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|EnumStrings|[LocalizedText](../../../Core/Part3/DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|

