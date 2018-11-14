<!-- objecttype -->
## BuildInfoType
  
<!-- end of text -->
The representation of the BuildInfoType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=3051|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|BuildInfoType|
|NodeClass|VariableType|
|DataType|[BuildInfo](../../DataTypes/BuildInfo/readme.md)|
|ValueRank|-1|
|IsAbstract|False|
|BaseType|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|
|Categories||

The references from the BuildInfoType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[ProductUri](#ProductUri)|[String](../../DataTypes/String/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[ManufacturerName](#ManufacturerName)|[String](../../DataTypes/String/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[ProductName](#ProductName)|[String](../../DataTypes/String/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[SoftwareVersion](#SoftwareVersion)|[String](../../DataTypes/String/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[BuildNumber](#BuildNumber)|[String](../../DataTypes/String/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[BuildDate](#BuildDate)|[UtcTime](../../DataTypes/UtcTime/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


