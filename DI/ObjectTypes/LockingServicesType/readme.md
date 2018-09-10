<!-- objecttype -->
## LockingServicesType
An interface for Locking.  
The representation of the LockingServicesType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|LockingServicesType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[BaseObjectType](../../../Core/Part5/ObjectTypes/BaseObjectType/readme.md)|

The references from the LockingServicesType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[Locked](#Locked)|[Boolean](../../../Core/Part3/DataTypes/Boolean/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[LockingClient](#LockingClient)|[String](../../../Core/Part3/DataTypes/String/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[LockingUser](#LockingUser)|[String](../../../Core/Part3/DataTypes/String/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasProperty](../../../Core/Part3/ReferenceTypes/HasProperty/readme.md)|Variable|[RemainingLockTime](#RemainingLockTime)|[Duration](../../../Core/Part3/DataTypes/Duration/readme.md)|[PropertyType](../../../Core/Part5/VariableTypes/PropertyType/readme.md)|[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Method|[InitLock](#InitLock)|||[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Method|[RenewLock](#RenewLock)|||[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Method|[ExitLock](#ExitLock)|||[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Method|[BreakLock](#BreakLock)|||[Mandatory](../../../Core/Objects/Mandatory/readme.md)|

### <a name="InitLock"></a>InitLock
  
**Signature**
```
    InitLock(
        [in]  String CurrentContext
        [in]  Int32 InitLockStatus
    );
```

|Argument|Description|
|---|---|
|CurrentContext||
|InitLockStatus||

### <a name="RenewLock"></a>RenewLock
  
**Signature**
```
    RenewLock(
        [in]  Int32 RenewLockStatus
    );
```

|Argument|Description|
|---|---|
|RenewLockStatus||

### <a name="ExitLock"></a>ExitLock
  
**Signature**
```
    ExitLock(
        [in]  Int32 ExitLockStatus
    );
```

|Argument|Description|
|---|---|
|ExitLockStatus||

### <a name="BreakLock"></a>BreakLock
  
**Signature**
```
    BreakLock(
        [in]  Int32 BreakLockStatus
    );
```

|Argument|Description|
|---|---|
|BreakLockStatus||


