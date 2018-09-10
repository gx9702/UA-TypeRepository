<!-- objecttype -->
## StateType
  
The representation of the StateType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|StateType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[BaseObjectType](../../../Part5/ObjectTypes/BaseObjectType/readme.md)|

The references from the StateType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[StateNumber](#StateNumber)|[UInt32](../../../Part3/DataTypes/UInt32/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[InitialStateType](#InitialStateType)||||


