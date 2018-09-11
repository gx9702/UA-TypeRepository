<!-- datatype -->
## DiagnosticsLevel
PubSub diagnostics are intended to assure users about the correct operation of a PubSub system and to help in the discovery of potential faults. Depending on the situation, not all diagnostic Objects might be needed, and on the other hand providing them requires resources. As a result, diagnostic objects are assigned to different diagnostic levels. Only diagnostic Objects belonging to the currently set diagnostic level or a more severe level have to be provided. This mechanism provides the user the ability to select a suitable diagnostic configuration depending on the application.

The DiagnosticsLevel is an enumeration that specifies the possible diagnostics levels. The possible enumeration values are described in Table 136.  
<!-- end of description -->
The fields of the DiagnosticsLevel DataType are defined in the following table:  

|Name|Value| Description|
|---|---|---|
|Basic|0||
|Advanced|1||
|Info|2||
|Log|3||
|Debug|4||

The representation of the DiagnosticsLevel DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=19723|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|DiagnosticsLevel|
|IsAbstract|False|
|BaseType|[Enumeration](../../../Part3/DataTypes/Enumeration/readme.md)|
|Categories|Part14|

The references from the DiagnosticsLevel DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|EnumStrings|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

