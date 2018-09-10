<!-- datatype -->
## NamingRuleType
<!-- end of description -->
The fields of the NamingRuleType DataType are defined in the following table:  

|Name|Value| Description|
|---|---|---|
|Mandatory|1|The BrowseName must appear in all instances of the type.|
|Optional|2|The BrowseName may appear in an instance of the type.|
|Constraint|3|The modelling rule defines a constraint and the BrowseName is not used in an instance of the type.|

The representation of the NamingRuleType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|NamingRuleType|
|IsAbtract|False|
|BaseType|[Enumeration](../../../Part3/DataTypes/Enumeration/readme.md)|

The references from the NamingRuleType DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|EnumValues|[EnumValueType](../../../Part3/DataTypes/EnumValueType/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

