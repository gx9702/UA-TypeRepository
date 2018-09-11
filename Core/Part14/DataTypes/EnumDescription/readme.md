<!-- datatype -->
## EnumDescription
This Structure DataType provides the concrete DataTypeDescription for Enumeration DataTypes. It is a subtype of the DataTypeDescription DataType. The EnumDescription is formally defined in Table A.7.  
<!-- end of description -->
The fields of the EnumDescription DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|EnumDescription|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;enumDefinition|[EnumDefinition](../../../Part3/DataTypes/EnumDefinition/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;builtInType|[Byte](../../../Part3/DataTypes/Byte/readme.md)||

The representation of the EnumDescription DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15488|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|EnumDescription|
|IsAbstract|False|
|BaseType|[DataTypeDescription](../../../Part14/DataTypes/DataTypeDescription/readme.md)|
|Categories|Part14|

