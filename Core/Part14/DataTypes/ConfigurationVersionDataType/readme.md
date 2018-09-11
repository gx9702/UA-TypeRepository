<!-- datatype -->
## ConfigurationVersionDataType
This Structure DataType is used to indicate configuration changes in the information published for a DataSet. The ConfigurationVersionDataType is formally defined in Table 8.  
<!-- end of description -->
The fields of the ConfigurationVersionDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|ConfigurationVersionDataType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;majorVersion|[VersionTime](../../../Part4/DataTypes/VersionTime/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;minorVersion|[VersionTime](../../../Part4/DataTypes/VersionTime/readme.md)||

The representation of the ConfigurationVersionDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=14593|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|ConfigurationVersionDataType|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part14|

