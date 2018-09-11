<!-- datatype -->
## ConnectionTransportDataType
This Structure DataType is an abstract base type for transport mapping specific PubSubConnection parameters. The abstract DataType does not define fields.

The ConnectionTransportDataType Structure representation in the AddressSpace is defined in Table 27.  
<!-- end of description -->
The fields of the ConnectionTransportDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|ConnectionTransportDataType|Structure||

The representation of the ConnectionTransportDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15618|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|ConnectionTransportDataType|
|IsAbstract|True|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part14|

The references from the ConnectionTransportDataType DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|DatagramConnectionTransportDataType||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|BrokerConnectionTransportDataType||||

