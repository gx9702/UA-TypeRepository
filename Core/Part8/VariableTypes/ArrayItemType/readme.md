[Core](/Core)/[Part8](/Core/Part8)/[VariableTypes](/Core/Part8/VariableTypes)
## ArrayItemType
### Overview
This VariableType defines the general characteristics of a DataItem. All other DataItem Types derive from it. The DataItemType derives from the BaseDataVariableType and therefore shares the variable model as described in Part 3 and Part 5.

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
|HasSubtype|VariableType|DiscreteItemType|
|HasSubtype|VariableType|ArrayItemType|
|HasProperty|Variable|[Definition](#Definition)|String|PropertyType|Optional|
|HasProperty|Variable|[ValuePrecision](#ValuePrecision)|Double|PropertyType|Optional|

### References
#### Definition
Definition is a vendor-specific, human readable string that specifies how the value of this DataItem is calculated. Definition is non-localized and will often contain an equation that can be parsed by certain clients.

#### ValuePrecision
ValuePrecision specifies the maximum precision that the Server can maintain for the item based on restrictions in the target environment.
ValuePrecision can be used for the following DataTypes:

* For Float and Double values it specifies the number of digits after the decimal place.
* For DateTime values it indicates the minimum time difference in nanoseconds. For example, a ValuePrecision of 20 000 000 defines a precision of 20 ms.

The ValuePrecision Property is an approximation that is intended to provide guidance to a Client. A Server is expected to silently round any value with more precision that it supports. This implies that a Client may encounter cases where the value read back from a Server differs from the value that it wrote to the Server. This difference shall be no more than the difference suggested by this Property
