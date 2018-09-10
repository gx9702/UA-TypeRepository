<!-- datatype -->
## UserTokenPolicy
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
|BrowseName|UserTokenPolicy|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

