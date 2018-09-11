<!-- datatype -->
## XVType
This structure defines a physical value relative to a X axis and it is used as the DataType of the Value of XYArrayItemType. For details see 5.3.4.3.  
Many devices can produce values that can perfectly be represented with a float IEEE 32 bits but, they can position them on the X axis with an accuracy that requires double IEEE 64 bits. For example, the peak value in an absorbance spectrum where the amplitude of the peak can be represented by a float IEEE 32 bits, but its frequency position required 10 digits which implies the use of a double IEEE 64 bits.  
Its elements are defined in Table 26.  
<!-- end of description -->
The fields of the XVType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|XVType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;x|[Double](../../../Part3/DataTypes/Double/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;value|[Float](../../../Part3/DataTypes/Float/readme.md)||

The representation of the XVType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=12080|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|XVType|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part8|

