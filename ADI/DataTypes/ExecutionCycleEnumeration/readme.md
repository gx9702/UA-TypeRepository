<!-- datatype -->
## ExecutionCycleEnumeration
  
<!-- end of description -->
The fields of the ExecutionCycleEnumeration DataType are defined in the following table:  

|Name|Value| Description|
|---|---|---|
|IDLE|0|Idle, no cleaning or acquisition cycle in progress.|
|DIAGNOSTIC|1|Scquisition cycle collecting data for diagnostic purpose.|
|CLEANING|2|Cleaning cycle.|
|CALIBRATION|4|Calibration acquisition cycle.|
|VALIDATION|8|Validation acquisition cycle.|
|SAMPLING|16|Sample acquisition cycle.|
|DIAGNOSTIC_WITH_GRAB_SAMPLE|32769|Scquisition cycle collecting data for diagnostic purpose and sample is extracted from the process to be sent in control lab.|
|CLEANING_WITH_GRAB_SAMPLE|32770|Cleaning cycle with or without acquisition and sample is extracted from the process to be sent in control lab.|
|CALIBRATION_WITH_GRAB_SAMPLE|32772|Calibration acquisition cycle and sample is extracted from the process to be sent in control lab.|
|VALIDATION_WITH_GRAB_SAMPLE|32776|Validation acquisition cycle and sample is extracted from the process to be sent in control lab.|
|SAMPLING_WITH_GRAB_SAMPLE|32784|Sample acquisition cycle and sample is extracted from the process to be sent in control lab.|

The representation of the ExecutionCycleEnumeration DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|ns=1;i=9378|
|NamespaceUri|http://opcfoundation.org/UA/ADI/|
|BrowseName|ExecutionCycleEnumeration|
|IsAbstract|False|
|BaseType|[Enumeration](../../../Core/Part3/DataTypes/Enumeration/readme.md)|
|Categories||

The references from the ExecutionCycleEnumeration DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|EnumValues|[EnumValueType](../../../Core/Part3/DataTypes/EnumValueType/readme.md)[]|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|

