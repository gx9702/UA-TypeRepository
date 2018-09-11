<!-- datatype -->
## UserTokenPolicy
Describes a user token that can be used with a server.  
<!-- end of description -->
The fields of the UserTokenPolicy DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|UserTokenPolicy|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;policyId|[String](../../../Part3/DataTypes/String/readme.md)|A identifier for the policy assigned by the server.|
|&nbsp;&nbsp;&nbsp;&nbsp;tokenType|[UserTokenType](../../../Part4/DataTypes/UserTokenType/readme.md)|The type of user token.|
|&nbsp;&nbsp;&nbsp;&nbsp;issuedTokenType|[String](../../../Part3/DataTypes/String/readme.md)|The type of issued token.|
|&nbsp;&nbsp;&nbsp;&nbsp;issuerEndpointUrl|[String](../../../Part3/DataTypes/String/readme.md)|The endpoint or any other information need to contruct an issued token URL.|
|&nbsp;&nbsp;&nbsp;&nbsp;securityPolicyUri|[String](../../../Part3/DataTypes/String/readme.md)|The security policy to use when encrypting or signing the user token.|

The representation of the UserTokenPolicy DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=304|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|UserTokenPolicy|
|IsAbstract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|
|Categories|Part4|

