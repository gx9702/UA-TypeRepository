[Core](/Core)/[Part8](/Core/Part8)
## Definitions ##

### DataItem
link to arbitrary, live automation data, that is, data that represents currently valid information
Note 1 to entry: Examples of such data are
* device data (such as temperature sensors),
* calculated data,
* status information (open/closed, moving),
* dynamically-changing system data (such as stock quotes),
* diagnostic data.

### AnalogItem
DataItems that represent continuously-variable physical quantities (e.g., length, temperature),
in contrast to the digital representation of data in discrete items

Note 1 to entry: Typical examples are the values provided by temperature sensors or pressure sensors. OPC UA
defines a specific VariableType to identify an AnalogItem. Properties describe the possible ranges of AnalogItems.
### DiscreteItem
DataItems that represent data that may take on only a certain number of possible values (e.g.,
OPENING, OPEN, CLOSING, CLOSED)
Note 1 to entry: Specific VariableTypes are used to identify DiscreteItems with two states or with multiple states.
Properties specify the string values for these states.
### ArrayItem
DataItems that represent continuously-variable physical quantities and where each individual
data point consists of multiple values represented by an array (e.g., the spectral response of
a digital filter)

Note 1 to entry: Typical examples are the data provided by analyser devices. Specific VariableTypes are used to
identify ArrayItem variants.
### EngineeringUnits
units of measurement for AnalogItems that represent continuously-variable physical quantities
(e.g., length, mass, time, temperature)