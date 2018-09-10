<!-- datatype -->
## ReferenceTypeNode
Specifies the attributes which belong to reference type nodes.  
<!-- end of description -->
The fields of the ReferenceTypeNode DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|ReferenceTypeNode|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;isAbstract|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)|If TRUE the type is abstract and only subtypes of it appear in the address space.|
|&nbsp;&nbsp;&nbsp;&nbsp;symmetric|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)|If TRUE the reference type has the same semantics in both directions.|
|&nbsp;&nbsp;&nbsp;&nbsp;inverseName|[LocalizedText](../../../Part3/DataTypes/LocalizedText/readme.md)|The display name for the reference when following it from target to source.|

The representation of the ReferenceTypeNode DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|ReferenceTypeNode|
|IsAbtract|False|
|BaseType|[TypeNode](../../../Part3/Services/TypeNode/readme.md)|

