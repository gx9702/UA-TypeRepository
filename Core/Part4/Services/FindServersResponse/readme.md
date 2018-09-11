<!-- datatype -->
## FindServersResponse
Finds the servers known to the discovery server.  
<!-- end of description -->
The fields of the FindServersResponse DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|FindServersResponse|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;responseHeader|[ResponseHeader](../../../Part4/Services/ResponseHeader/readme.md)|A standard header included in all responses returned by servers.|
|&nbsp;&nbsp;&nbsp;&nbsp;servers|[ApplicationDescription](../../../Part4/DataTypes/ApplicationDescription/readme.md)[]|The servers that met the criteria specified in the request.|

The representation of the FindServersResponse DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=423|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|FindServersResponse|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part4/Services|

