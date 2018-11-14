<!-- objecttype -->
## ServerType
Specifies the current status and capabilities of the server.  
<!-- end of text -->
The representation of the ServerType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=2004|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|ServerType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[BaseObjectType](../../ObjectTypes/BaseObjectType/readme.md)|
|Categories||

The references from the ServerType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ServerArray](#ServerArray)|[String](../../DataTypes/String/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[NamespaceArray](#NamespaceArray)|[String](../../DataTypes/String/readme.md)[]|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[UrisVersion](#UrisVersion)|[VersionTime](../../DataTypes/VersionTime/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Variable|[ServerStatus](#ServerStatus)|[ServerStatusDataType](../../DataTypes/ServerStatusDataType/readme.md)|[ServerStatusType](../../VariableTypes/ServerStatusType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[ServiceLevel](#ServiceLevel)|[Byte](../../DataTypes/Byte/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[Auditing](#Auditing)|[Boolean](../../DataTypes/Boolean/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[EstimatedReturnTime](#EstimatedReturnTime)|[DateTime](../../DataTypes/DateTime/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../ReferenceTypes/HasProperty/readme.md)|Variable|[LocalTime](#LocalTime)|[TimeZoneDataType](../../DataTypes/TimeZoneDataType/readme.md)|[PropertyType](../../VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[ServerCapabilities](#ServerCapabilities)||[ServerCapabilitiesType](../../ObjectTypes/ServerCapabilitiesType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[ServerDiagnostics](#ServerDiagnostics)||[ServerDiagnosticsType](../../ObjectTypes/ServerDiagnosticsType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[VendorServerInfo](#VendorServerInfo)||[VendorServerInfoType](../../ObjectTypes/VendorServerInfoType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[ServerRedundancy](#ServerRedundancy)||[ServerRedundancyType](../../ObjectTypes/ServerRedundancyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Object|[Namespaces](#Namespaces)||[NamespacesType](../../ObjectTypes/NamespacesType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[GetMonitoredItems](#GetMonitoredItems)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[ResendData](#ResendData)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[SetSubscriptionDurable](#SetSubscriptionDurable)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../ReferenceTypes/HasComponent/readme.md)|Method|[RequestServerStateChange](#RequestServerStateChange)|||[Optional](../../Objects/Optional/readme.md)|

### <a name="GetMonitoredItems"></a>GetMonitoredItems
  
**Signature**
```
    GetMonitoredItems(
        [in]  UInt32 SubscriptionId
        [in]  UInt32 ServerHandles
        [in]  UInt32 ClientHandles
    );
```

|Argument|Description|
|---|---|
|SubscriptionId||
|ServerHandles||
|ClientHandles||

### <a name="ResendData"></a>ResendData
  
**Signature**
```
    ResendData(
        [in]  UInt32 SubscriptionId
    );
```

|Argument|Description|
|---|---|
|SubscriptionId||

### <a name="SetSubscriptionDurable"></a>SetSubscriptionDurable
  
**Signature**
```
    SetSubscriptionDurable(
        [in]  UInt32 SubscriptionId
        [in]  UInt32 LifetimeInHours
        [in]  UInt32 RevisedLifetimeInHours
    );
```

|Argument|Description|
|---|---|
|SubscriptionId||
|LifetimeInHours||
|RevisedLifetimeInHours||

### <a name="RequestServerStateChange"></a>RequestServerStateChange
  
**Signature**
```
    RequestServerStateChange(
        [in]  ServerState State
        [in]  DateTime EstimatedReturnTime
        [in]  UInt32 SecondsTillShutdown
        [in]  LocalizedText Reason
        [in]  Boolean Restart
    );
```

|Argument|Description|
|---|---|
|State||
|EstimatedReturnTime||
|SecondsTillShutdown||
|Reason||
|Restart||


