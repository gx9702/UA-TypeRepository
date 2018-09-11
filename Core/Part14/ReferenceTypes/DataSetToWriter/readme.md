<!-- objecttype -->
## DataSetToWriter
The DataSetToWriter ReferenceType is a concrete ReferenceType that can be used directly. It is a subtype of the HierarchicalReferences ReferenceType.

The SourceNode of References of this type shall be an Object of ObjectType PublishedDataSetType or an ObjectType that is a subtype of PublishedDataSetType defined in 9.1.4.2.1.

The TargetNode of this ReferenceType shall be an Object of the ObjectType DataSetWriterType defined in 9.1.7.1.

Each DataSetWriter Object shall be the TargetNode of exactly one DataSetToWriter Reference.

Servers shall provide the inverse Reference that relates a DataSetWriter Object back to a PublishedDataSetType Object.

The representation of the DataSetToWriter ReferenceType in the AddressSpace is specified in Table 108.  
<!-- end of text -->
The representation of the DataSetToWriter ReferenceType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|NodeId|i=14936|
|NamespaceUri|http://opcfoundation.org/UA/|
|BrowseName|DataSetToWriter|
|NodeClass|ReferenceType|
|IsAbstract|False|
|BaseType|[HierarchicalReferences](../../../Part3/ReferenceTypes/HierarchicalReferences/readme.md)|
|Categories|Part14|

