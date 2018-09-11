<!-- objecttype -->
## PubSubDiagnosticsReaderGroupType
The PubSubDiagnosticsReaderGroupType defines the diagnostic information for a ReaderGroupType Object and is formally defined in Table 146.  
<!-- end of text -->
The representation of the PubSubDiagnosticsReaderGroupType ObjectType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=19903|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|PubSubDiagnosticsReaderGroupType|
|NodeClass|ObjectType|
|IsAbstract|False|
|BaseType|[PubSubDiagnosticsType](../../../Part14/ObjectTypes/PubSubDiagnosticsType/readme.md)|
|Categories|Part14|

The references from the PubSubDiagnosticsReaderGroupType ObjectType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[Counters](#Counters)||[BaseObjectType](../../Part5/ObjectTypes/BaseObjectType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|
|[HasComponent](../../../Part3/ReferenceTypes/HasComponent/readme.md)|Object|[LiveValues](#LiveValues)||[BaseObjectType](../../Part5/ObjectTypes/BaseObjectType/readme.md)|[Mandatory](../../Objects/Mandatory/readme.md)|


