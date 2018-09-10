<!-- objecttype -->
## HasChild
The abstract base type for all non-looping hierarchical references.  
The representation of the HasChild ReferenceType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|HasChild|
|NodeClass|ReferenceType|
|IsAbtract|False|
|BaseType|[HierarchicalReferences](../../../Part3/ReferenceTypes/HierarchicalReferences/readme.md)|

The references from the HasChild ReferenceType Node are shown in the following table:  

|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|
|---|---|---|---|---|---|
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ReferenceType|[Aggregates](#Aggregates)||||
|[HasSubtype](../../../Part3/ReferenceTypes/HasSubtype/readme.md)|ReferenceType|[HasSubtype](#HasSubtype)||||


