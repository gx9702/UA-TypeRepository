<!-- objecttype -->
## CertificateExpirationAlarmType
The representation of the CertificateExpirationAlarmType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|CertificateExpirationAlarmType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[SystemOffNormalAlarmType](../../../Part9/ObjectTypes/SystemOffNormalAlarmType/readme.md)|

The references from the CertificateExpirationAlarmType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|ExpirationDate||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|ExpirationLimit||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|CertificateType||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|Certificate||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

