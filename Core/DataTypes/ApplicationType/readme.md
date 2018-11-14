<!-- datatype -->
## ApplicationType
The types of applications.  
<!-- end of description -->
The fields of the ApplicationType DataType are defined in the following table:  

|Name|Value| Description|
|---|---|---|
|Server|0|The application is a server.|
|Client|1|The application is a client.|
|ClientAndServer|2|The application is a client and a server.|
|DiscoveryServer|3|The application is a discovery server.|

The representation of the ApplicationType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=307|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|ApplicationType|
|IsAbstract|False|
|BaseType|[Enumeration](../../DataTypes/Enumeration/readme.md)|
|Categories||

The references from the ApplicationType DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|EnumStrings|[LocalizedText](../../DataTypes/LocalizedText/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|

