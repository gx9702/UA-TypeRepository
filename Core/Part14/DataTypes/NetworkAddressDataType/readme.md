<!-- datatype -->
## NetworkAddressDataType
Subtypes of this abstract Structure DataType are used to represent network address information. The NetworkAddressDataType is formally defined in Table 28.  
<!-- end of description -->
The fields of the NetworkAddressDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|NetworkAddressDataType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;networkInterface|[String](../../../Part3/DataTypes/String/readme.md)||

The representation of the NetworkAddressDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15502|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|NetworkAddressDataType|
|IsAbstract|True|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part14|

The references from the NetworkAddressDataType DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|NetworkAddressUrlDataType||||

