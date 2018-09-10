<!-- objecttype -->
## MVAOutputParameterType
Hold the descriptions of a mathematical process and associated information to convert scaled data into one or more process values.  
The representation of the MVAOutputParameterType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|MVAOutputParameterType|
|NodeClass|VariableType|
|IsAbtract|False|
|BaseType|[BaseDataVariableType](../../../Core/Part5/VariableTypes/BaseDataVariableType/readme.md)|

The references from the MVAOutputParameterType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[WarningLimits](#WarningLimits)|[Range](../../../Core/Part8/DataTypes/Range/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[AlarmLimits](#AlarmLimits)|[Range](../../../Core/Part8/DataTypes/Range/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[AlarmState](#AlarmState)|[AlarmStateEnumeration](../../DataTypes/AlarmStateEnumeration/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[VendorSpecificError](#VendorSpecificError)|[String](../../../Core/Part3/DataTypes/String/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../../Core/Objects/Optional/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[Statistics](#Statistics)|[BaseDataType](../../../Core/Part3/DataTypes/BaseDataType/readme.md)[]|[MVAOutputParameterType](../../VariableTypes/MVAOutputParameterType/readme.md)|[OptionalPlaceholder](../../../Core/Objects/OptionalPlaceholder/readme.md)|


