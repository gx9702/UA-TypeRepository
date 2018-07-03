[Core](/Core)/[Part8](/Core/Part8)/[VariableTypes](/Core/Part8/VariableTypes)
## DataItemType

### Overview
This _VariableType_ defines the general characteristics of a _DataItem_ . All other _DataItem_  Types derive from it. The _DataItemType_ derives from the _BaseDataVariableType_ and therefore shares the variable model as described in Part 3 and Part 5.

### Definition
|Attribute|Value|
|---|---|
|BrowseName|DiscreteItemType|
|IsAbstract|True|
|ValueRank|−2 (−2 = ‘Any’)|
|DataType|BaseDataType|
|BaseType|BaseDataVariableType|

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|HasSubtype|VariableType|[AnalogItemType](../AnalogItemType/readme.md)|
|HasSubtype|VariableType|[DiscreteItemType](../DiscreteItemType/readme.md)|
|HasSubtype|VariableType|[ArrayItemType](../ArrayItemType/readme.md)|
|HasProperty|Variable|[Definition](#Definition)|String|PropertyType|Optional|
|HasProperty|Variable|[ValuePrecision](#ValuePrecision)|Double|PropertyType|Optional|

### References
#### Definition
Definition is a vendor-specific, human readable string that specifies how the value of this _DataItem_ is calculated. _Definition_ is non-localized and will often contain an equation that can be parsed by certain clients.

#### ValuePrecision
_ValuePrecision_ specifies the maximum precision that the _Server_ can maintain for the item based on restrictions in the target environment.
_ValuePrecision_ can be used for the following DataTypes:

* For _Float_ and _Double_ values it specifies the number of digits after the decimal place.
* For _DateTime_ values it indicates the minimum time difference in nanoseconds. For example, a _ValuePrecision_ of 20 000 000 defines a precision of 20 ms.

The _ValuePrecision_ _Property_ is an approximation that is intended to provide guidance to a _Client_. A _Server_ is expected to silently round any value with more precision that it supports. This implies that a Client may encounter cases where the value read back from a Server differs from the value that it wrote to the _Server_. This difference shall be no more than the difference suggested by this _Property_
