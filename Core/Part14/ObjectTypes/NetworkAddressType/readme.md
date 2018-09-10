<!-- objecttype -->
## NetworkAddressType
  
The representation of the NetworkAddressType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|NetworkAddressType|
|NodeClass|ObjectType|
|IsAbtract|True|
|BaseType|[BaseObjectType](../../../Part5/ObjectTypes/BaseObjectType/readme.md)|

The references from the NetworkAddressType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[NetworkInterface](#NetworkInterface)|[String](../../../Part3/DataTypes/String/readme.md)|[BaseDataVariableType](../../Part5/VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[NetworkAddressUrlType](#NetworkAddressUrlType)||||


