<!-- datatype -->
## FilterOperator
<!-- end of description -->
The fields of the FilterOperator DataType are defined in the following table:  

|Name|Value| Description|
|---|---|---|
|Equals|0||
|IsNull|1||
|GreaterThan|2||
|LessThan|3||
|GreaterThanOrEqual|4||
|LessThanOrEqual|5||
|Like|6||
|Not|7||
|Between|8||
|InList|9||
|And|10||
|Or|11||
|Cast|12||
|InView|13||
|OfType|14||
|RelatedTo|15||
|BitwiseAnd|16||
|BitwiseOr|17||

The representation of the FilterOperator DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|FilterOperator|
|IsAbtract|False|
|BaseType|[Enumeration](../../../Part3/DataTypes/Enumeration/readme.md)|

The references from the FilterOperator DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|EnumStrings|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

