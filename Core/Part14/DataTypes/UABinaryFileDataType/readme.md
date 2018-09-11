<!-- datatype -->
## UABinaryFileDataType
This Structure DataType defines the base layout of an OPC UA Binary encoded file. The contend of the file is the UABinaryFileDataType encoded as ExtensionObject.

The file specific meta data is provided by the DataTypeSchemaHeader which is the base type for the UABinaryFileDataType Structure.

If the file is provided through a FileType Object, the MimeType Property of the Object shall have the value application/opcua+uabinary.

If the file is stored on disc, the file extension shall be uabinary.

The UABinaryFileDataType is formally defined in Table A.10.  
<!-- end of description -->
The fields of the UABinaryFileDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|UABinaryFileDataType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;schemaLocation|[String](../../../Part3/DataTypes/String/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;fileHeader|[KeyValuePair](../../../Part5/DataTypes/KeyValuePair/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;body|[BaseDataType](../../../Part3/DataTypes/BaseDataType/readme.md)||

The representation of the UABinaryFileDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=15006|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|UABinaryFileDataType|
|IsAbstract|False|
|BaseType|[DataTypeSchemaHeader](../../../Part14/DataTypes/DataTypeSchemaHeader/readme.md)|
|Categories|Part14|

