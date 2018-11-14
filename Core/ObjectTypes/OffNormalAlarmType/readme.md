<!-- objecttype -->
## OffNormalAlarmType
  
<!-- end of text -->
The representation of the OffNormalAlarmType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=10637|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|OffNormalAlarmType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[DiscreteAlarmType](../../ObjectTypes/DiscreteAlarmType/readme.md)|
|Categories||

The references from the OffNormalAlarmType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[NormalState](#NormalState)|[NodeId](../../DataTypes/NodeId/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[SystemOffNormalAlarmType](#SystemOffNormalAlarmType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[TripAlarmType](#TripAlarmType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[InstrumentDiagnosticAlarmType](#InstrumentDiagnosticAlarmType)||||
|[HasSubtype](../../ReferenceTypes/HasSubtype/readme.md)|ObjectType|[SystemDiagnosticAlarmType](#SystemDiagnosticAlarmType)||||


