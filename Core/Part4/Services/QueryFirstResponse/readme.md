<!-- datatype -->
## QueryFirstResponse
<!-- end of description -->
The fields of the QueryFirstResponse DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|QueryFirstResponse|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;responseHeader|[ResponseHeader](../../../Part4/Services/ResponseHeader/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;queryDataSets|[QueryDataSet](../../../Part4/Services/QueryDataSet/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;continuationPoint|[ContinuationPoint](../../../Part4/DataTypes/ContinuationPoint/readme.md)||
|&nbsp;&nbsp;&nbsp;&nbsp;parsingResults|[ParsingResult](../../../Part4/Services/ParsingResult/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;diagnosticInfos|[DiagnosticInfo](../../../Part4/DataTypes/DiagnosticInfo/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;filterResult|[ContentFilterResult](../../../Part4/Services/ContentFilterResult/readme.md)||

The representation of the QueryFirstResponse DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|QueryFirstResponse|
|IsAbtract|False|
|BaseType|[Structure](../../../Part3/DataTypes/Structure/readme.md)|

