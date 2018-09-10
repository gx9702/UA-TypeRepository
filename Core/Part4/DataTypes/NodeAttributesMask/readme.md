<!-- datatype -->
## NodeAttributesMask
<!-- end of description -->
The fields of the NodeAttributesMask DataType are defined in the following table:  

|Name|Value| Description|
|---|---|---|
|None|0|No attribuites provided.|
|AccessLevel|1|The access level attribute is specified.|
|ArrayDimensions|2|The array dimensions attribute is specified.|
|BrowseName|4|The browse name attribute is specified.|
|ContainsNoLoops|8|The contains no loops attribute is specified.|
|DataType|16|The data type attribute is specified.|
|Description|32|The description attribute is specified.|
|DisplayName|64|The display name attribute is specified.|
|EventNotifier|128|The event notifier attribute is specified.|
|Executable|256|The executable attribute is specified.|
|Historizing|512|The historizing attribute is specified.|
|InverseName|1024|The inverse name attribute is specified.|
|IsAbstract|2048|The is abstract attribute is specified.|
|MinimumSamplingInterval|4096|The minimum sampling interval attribute is specified.|
|NodeClass|8192|The node class attribute is specified.|
|NodeId|16384|The node id attribute is specified.|
|Symmetric|32768|The symmetric attribute is specified.|
|UserAccessLevel|65536|The user access level attribute is specified.|
|UserExecutable|131072|The user executable attribute is specified.|
|UserWriteMask|262144|The user write mask attribute is specified.|
|ValueRank|524288|The value rank attribute is specified.|
|WriteMask|1048576|The write mask attribute is specified.|
|Value|2097152|The value attribute is specified.|
|DataTypeDefinition|4194304|The write mask attribute is specified.|
|RolePermissions|8388608|The write mask attribute is specified.|
|AccessRestrictions|16777216|The write mask attribute is specified.|
|All|33554431|All attributes are specified.|
|BaseNode|26501220|All base attributes are specified.|
|Object|26501348|All object attributes are specified.|
|ObjectType|26503268|All object type attributes are specified.|
|Variable|26571383|All variable attributes are specified.|
|VariableType|28600438|All variable type attributes are specified.|
|Method|26632548|All method attributes are specified.|
|ReferenceType|26537060|All reference type attributes are specified.|
|View|26501356|All view attributes are specified.|

The representation of the NodeAttributesMask DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|NodeAttributesMask|
|IsAbtract|False|
|BaseType|[Enumeration](../../../Part3/DataTypes/Enumeration/readme.md)|

The references from the NodeAttributesMask DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|EnumValues||[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

