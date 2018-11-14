<!-- datatype -->
## RegisteredServer
The information required to register a server with a discovery server.  
<!-- end of description -->
The fields of the RegisteredServer DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|RegisteredServer|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;serverUri|[String](../../DataTypes/String/readme.md)|The globally unique identifier for the server.|
|&nbsp;&nbsp;&nbsp;&nbsp;productUri|[String](../../DataTypes/String/readme.md)|The globally unique identifier for the product.|
|&nbsp;&nbsp;&nbsp;&nbsp;serverNames|[LocalizedText](../../DataTypes/LocalizedText/readme.md)[]|The name of server in multiple lcoales.|
|&nbsp;&nbsp;&nbsp;&nbsp;serverType|[ApplicationType](../../DataTypes/ApplicationType/readme.md)|The type of server.|
|&nbsp;&nbsp;&nbsp;&nbsp;gatewayServerUri|[String](../../DataTypes/String/readme.md)|The globally unique identifier for the server that is acting as a gateway for the server.|
|&nbsp;&nbsp;&nbsp;&nbsp;discoveryUrls|[String](../../DataTypes/String/readme.md)[]|The URLs for the server's discovery endpoints.|
|&nbsp;&nbsp;&nbsp;&nbsp;semaphoreFilePath|[String](../../DataTypes/String/readme.md)|A path to a file that is deleted when the server is no longer accepting connections.|
|&nbsp;&nbsp;&nbsp;&nbsp;isOnline|[Boolean](../../DataTypes/Boolean/readme.md)|If FALSE the server will save the registration information to a persistent datastore.|

The representation of the RegisteredServer DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=432|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|RegisteredServer|
|IsAbstract|False|
|BaseType|[Structure](../../DataTypes/Structure/readme.md)|
|Categories||

