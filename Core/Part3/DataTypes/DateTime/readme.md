<!-- datatype -->
## DateTime
Describes a value that is a Gregorian calender date and time.  
<!-- end of description -->
The fields of the DateTime DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|DateTime|Structure||

The representation of the DateTime DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=13|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|DateTime|
|IsAbstract|False|
|BaseType|[BaseDataType](../../../Part3/DataTypes/BaseDataType/readme.md)|
|Categories|Part3|

The references from the DateTime DataType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|UtcTime||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|DataType|Date||||

