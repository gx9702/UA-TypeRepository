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
|DataType|[BuildInfo](../../../Part5/DataTypes/BuildInfo/readme.md)|
|ValueRank|-1|
|IsAbstract|False|
|BaseType|[BaseDataVariableType](../../../Part5/VariableTypes/BaseDataVariableType/readme.md)|
|Categories|Part5|

The references from the BuildInfoType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[ProductUri](#ProductUri)|[String](../../../Part3/DataTypes/String/readme.md)|[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[ManufacturerName](#ManufacturerName)|[String](../../../Part3/DataTypes/String/readme.md)|[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[ProductName](#ProductName)|[String](../../../Part3/DataTypes/String/readme.md)|[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[SoftwareVersion](#SoftwareVersion)|[String](../../../Part3/DataTypes/String/readme.md)|[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[BuildNumber](#BuildNumber)|[String](../../../Part3/DataTypes/String/readme.md)|[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[BuildDate](#BuildDate)|[UtcTime](../../../Part3/DataTypes/UtcTime/readme.md)|[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


