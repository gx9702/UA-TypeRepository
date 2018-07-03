## VariableTypes ##

### [DataItemType](DataItemType/readme.md) ###
This VariableType defines the general characteristics of a DataItem. All other DataItem Types derive from it. The DataItemType derives from the BaseDataVariableType and therefore shares the variable model as described in Part 3 and Part 5. 

### [AnalogItemType](AnalogItemType/readme.md) ###
This VariableType defines the general characteristics of an AnalogItem. All other AnalogItem Types derive from it. The AnalogItemType derives from the DataItemType. 

### [DiscreteItemType](DiscreteItemType/readme.md) ###
This VariableType is an abstract type. That is, no instances of this type can exist. However, it might be used in a filter when browsing or querying. The DiscreteItemType derives from the DataItemType and therefore shares all of its characteristics. 
