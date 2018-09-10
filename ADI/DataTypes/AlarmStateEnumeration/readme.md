<!-- datatype -->
## AlarmStateEnumeration
<!-- end of description -->
The fields of the AlarmStateEnumeration DataType are defined in the following table:  

|Name|Value| Description|
|---|---|---|
|NORMAL_0|0|Normal.|
|WARNING_LOW_1|1|In low warning range.|
|WARNING_HIGH_2|2|In high warning range.|
|WARNING_4|4|In warning range (low or high) or some other warning cause.|
|ALARM_LOW_8|8|In low alarm range.|
|ALARM_HIGH_16|16|In high alarm range.|
|ALARM_32|32|In alarm range (low or high) or some other alarm cause.|

The representation of the AlarmStateEnumeration DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|AlarmStateEnumeration|
|IsAbtract|False|
|BaseType|[Enumeration](../../../Core/Part3/DataTypes/Enumeration/readme.md)|

The references from the AlarmStateEnumeration DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|EnumValues|[EnumValueType](../../../Core/Part3/DataTypes/EnumValueType/readme.md)[]|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|

