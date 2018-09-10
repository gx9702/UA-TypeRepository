<!-- datatype -->
## DeviceHealthEnumeration
<!-- end of description -->
The fields of the DeviceHealthEnumeration DataType are defined in the following table:  

|Name|Value| Description|
|---|---|---|
|NORMAL|0|This device functions normally.|
|FAILURE|1|Malfunction of the device or any of its peripherals.|
|CHECK_FUNCTION|2|Functional checks are currently performed.|
|OFF_SPEC|3|The device is currently working outside of its specified range or that internal diagnoses indicate deviations from measured or set values.|
|MAINTENANCE_REQUIRED|4|This element is working, but a maintenance operation is required.|

The representation of the DeviceHealthEnumeration DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|DeviceHealthEnumeration|
|IsAbtract|False|
|BaseType|[Enumeration](../../../Core/Part3/DataTypes/Enumeration/readme.md)|

The references from the DeviceHealthEnumeration DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|EnumStrings|[LocalizedText](../../../Core/Part3/DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|

