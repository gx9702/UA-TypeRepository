<!-- objecttype -->
## ServerType
Specifies the current status and capabilities of the server.  
The representation of the ServerType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|ServerType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[BaseObjectType](../../../Part5/ObjectTypes/BaseObjectType/readme.md)|

The references from the ServerType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ServerArray](#ServerArray)|[String](../../../Part3/DataTypes/String/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[NamespaceArray](#NamespaceArray)|[String](../../../Part3/DataTypes/String/readme.md)[]|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[UrisVersion](#UrisVersion)|[VersionTime](../../../Part4/DataTypes/VersionTime/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Variable|[ServerStatus](#ServerStatus)|[ServerStatusDataType](../../../Part5/DataTypes/ServerStatusDataType/readme.md)|[ServerStatusType](../../Part5/VariableTypes/ServerStatusType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[ServiceLevel](#ServiceLevel)|[Byte](../../../Part3/DataTypes/Byte/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[Auditing](#Auditing)|[Boolean](../../../Part3/DataTypes/Boolean/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[EstimatedReturnTime](#EstimatedReturnTime)|[DateTime](../../../Part3/DataTypes/DateTime/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasProperty](../../../Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[LocalTime](#LocalTime)|[TimeZoneDataType](../../../Part3/DataTypes/TimeZoneDataType/readme.md)|[PropertyType](../../Part5/VariableTypes/PropertyType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[ServerCapabilities](#ServerCapabilities)||[ServerCapabilitiesType](../../Part5/ObjectTypes/ServerCapabilitiesType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[ServerDiagnostics](#ServerDiagnostics)||[ServerDiagnosticsType](../../Part5/ObjectTypes/ServerDiagnosticsType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[VendorServerInfo](#VendorServerInfo)||[VendorServerInfoType](../../Part5/ObjectTypes/VendorServerInfoType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[ServerRedundancy](#ServerRedundancy)||[ServerRedundancyType](../../Part5/ObjectTypes/ServerRedundancyType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Namespaces](#Namespaces)||[NamespacesType](../../Part5/ObjectTypes/NamespacesType/readme.md)|[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[GetMonitoredItems](#GetMonitoredItems)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[ResendData](#ResendData)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[SetSubscriptionDurable](#SetSubscriptionDurable)|||[Optional](../../Objects/Optional/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Method|[RequestServerStateChange](#RequestServerStateChange)|||[Optional](../../Objects/Optional/readme.md)|

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


