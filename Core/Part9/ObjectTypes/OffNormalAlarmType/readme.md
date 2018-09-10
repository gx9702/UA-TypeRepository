<!-- objecttype -->
## OffNormalAlarmType
  
The representation of the OffNormalAlarmType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|OffNormalAlarmType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[DiscreteAlarmType](../../../Part9/ObjectTypes/DiscreteAlarmType/readme.md)|

The references from the OffNormalAlarmType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[NormalState](#NormalState)|[NodeId](../../../Part3/DataTypes/NodeId/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[SystemOffNormalAlarmType](#SystemOffNormalAlarmType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[TripAlarmType](#TripAlarmType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[InstrumentDiagnosticAlarmType](#InstrumentDiagnosticAlarmType)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ObjectType|[SystemDiagnosticAlarmType](#SystemDiagnosticAlarmType)||||


