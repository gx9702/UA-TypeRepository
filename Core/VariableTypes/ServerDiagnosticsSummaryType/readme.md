<!-- objecttype -->
## ServerDiagnosticsSummaryType
  
<!-- end of text -->
The representation of the ServerDiagnosticsSummaryType VariableType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2150|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|ServerDiagnosticsSummaryType|
|NodeClass|VariableType|
|DataType|[ServerDiagnosticsSummaryDataType](../../DataTypes/ServerDiagnosticsSummaryDataType/readme.md)|
|ValueRank|-1|
|IsAbstract|False|
|BaseType|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|
|Categories||

The references from the ServerDiagnosticsSummaryType VariableType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[ServerViewCount](#ServerViewCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[CurrentSessionCount](#CurrentSessionCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[CumulatedSessionCount](#CumulatedSessionCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[SecurityRejectedSessionCount](#SecurityRejectedSessionCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[RejectedSessionCount](#RejectedSessionCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[SessionTimeoutCount](#SessionTimeoutCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[SessionAbortCount](#SessionAbortCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[PublishingIntervalCount](#PublishingIntervalCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[CurrentSubscriptionCount](#CurrentSubscriptionCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[CumulatedSubscriptionCount](#CumulatedSubscriptionCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[SecurityRejectedRequestsCount](#SecurityRejectedRequestsCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[RejectedRequestsCount](#RejectedRequestsCount)|[UInt32](../../DataTypes/UInt32/readme.md)|[BaseDataVariableType](../../VariableTypes/BaseDataVariableType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


