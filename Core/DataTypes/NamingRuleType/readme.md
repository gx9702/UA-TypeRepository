<!-- datatype -->
## NamingRuleType
Describes a value that specifies the significance of the BrowseName for an instance declaration.  
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
|NodeId|i=120|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|NamingRuleType|
|IsAbstract|False|
|BaseType|[Enumeration](../../DataTypes/Enumeration/readme.md)|
|Categories||

The references from the NamingRuleType DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|EnumValues|[EnumValueType](../../DataTypes/EnumValueType/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

