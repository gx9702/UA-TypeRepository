<!-- objecttype -->
## TransferServicesType

The representation of the TransferServicesType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|TransferServicesType|
|NodeClass|ObjectType|
|IsAbtract|False|
|BaseType|[BaseObjectType](../../../Core/Part5/ObjectTypes/BaseObjectType/readme.md)|

The references from the TransferServicesType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Method|[TransferToDevice](#TransferToDevice)|||[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Method|[TransferFromDevice](#TransferFromDevice)|||[Mandatory](../../../Core/Objects/Mandatory/readme.md)|
|[HasComponent](../../../Core/Part3/ReferenceTypes/HasComponent/readme.md)|Method|[FetchTransferResultData](#FetchTransferResultData)|||[Mandatory](../../../Core/Objects/Mandatory/readme.md)|

### <a name="TransferToDevice"></a>TransferToDevice

**Signature**
```
    TransferToDevice(
        [in]  Int32 TransferID
        [in]  Int32 InitTransferStatus
    );
```

|Argument|Description|
|---|---|
|TransferID||
|InitTransferStatus||

### <a name="TransferFromDevice"></a>TransferFromDevice

**Signature**
```
    TransferFromDevice(
        [in]  Int32 TransferID
        [in]  Int32 InitTransferStatus
    );
```

|Argument|Description|
|---|---|
|TransferID||
|InitTransferStatus||

### <a name="FetchTransferResultData"></a>FetchTransferResultData

**Signature**
```
    FetchTransferResultData(
        [in]  Int32 TransferID
        [in]  Int32 SequenceNumber
        [in]  Int32 MaxParameterResultsToReturn
        [in]  Boolean OmitGoodResults
        [in]  FetchResultDataType FetchResult
    );
```

|Argument|Description|
|---|---|
|TransferID||
|SequenceNumber||
|MaxParameterResultsToReturn||
|OmitGoodResults||
|FetchResult||


