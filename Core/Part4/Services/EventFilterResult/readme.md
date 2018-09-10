<!-- datatype -->
## EventFilterResult
<!-- end of description -->
The fields of the EventFilterResult DataType are defined in the following table:  

|Name|Type|Description|
|---|---|---|
|EventFilterResult|Structure||
|&nbsp;&nbsp;&nbsp;&nbsp;selectClauseResults|[StatusCode](../../../Part4/DataTypes/StatusCode/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;selectClauseDiagnosticInfos|[DiagnosticInfo](../../../Part4/DataTypes/DiagnosticInfo/readme.md)[]||
|&nbsp;&nbsp;&nbsp;&nbsp;whereClauseResult|[ContentFilterResult](../../../Part4/Services/ContentFilterResult/readme.md)||

The representation of the EventFilterResult DataType in the address space is shown in the following table:  

|Name|Attribute|
|---|---|
|BrowseName|EventFilterResult|
|IsAbtract|False|
|BaseType|[MonitoringFilterResult](../../../Part4/Services/MonitoringFilterResult/readme.md)|

