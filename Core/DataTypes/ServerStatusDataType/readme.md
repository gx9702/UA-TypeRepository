<!-- datatype -->
## ServerStatusDataType
  
<!-- end of description -->
The fields of the ServerStatusDataType DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|ServerStatusDataType|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;startTime|[UtcTime](../../DataTypes/UtcTime/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;currentTime|[UtcTime](../../DataTypes/UtcTime/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;state|[ServerState](../../DataTypes/ServerState/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;buildInfo|[BuildInfo](../../DataTypes/BuildInfo/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;secondsTillShutdown|[UInt32](../../DataTypes/UInt32/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;shutdownReason|[LocalizedText](../../DataTypes/LocalizedText/readme.md)||

The representation of the ServerStatusDataType DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=862|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|ServerStatusDataType|
|IsAbstract|False|
|BaseType|[Structure](../../DataTypes/Structure/readme.md)|
|Categories||

