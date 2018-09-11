<!-- datatype -->
## ApplicationDescription
Describes an application and how to find it.  
<!-- end of description -->
The fields of the ApplicationDescription DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|ApplicationDescription|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;applicationUri|[String](../../../Part3/DataTypes/String/readme.md)|The globally unique identifier for the application.|
|&nbsp;&nbsp;&nbsp;&nbsp;productUri|[String](../../../Part3/DataTypes/String/readme.md)|The globally unique identifier for the product.|
|&nbsp;&nbsp;&nbsp;&nbsp;applicationName|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)|The name of application.|
|&nbsp;&nbsp;&nbsp;&nbsp;applicationType|[ApplicationType](../../../Part4/DataTypes/ApplicationType/readme.md)|The type of application.|
|&nbsp;&nbsp;&nbsp;&nbsp;gatewayServerUri|[String](../../../Part3/DataTypes/String/readme.md)|The globally unique identifier for the server that is acting as a gateway for the server.|
|&nbsp;&nbsp;&nbsp;&nbsp;discoveryProfileUri|[String](../../../Part3/DataTypes/String/readme.md)|The globally unique identifier for the discovery profile supported by the server.|
|&nbsp;&nbsp;&nbsp;&nbsp;discoveryUrls|[String](../../../Part3/DataTypes/String/readme.md)[]|The URLs for the server's discovery endpoints.|

The representation of the ApplicationDescription DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=308|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|ApplicationDescription|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part4|

