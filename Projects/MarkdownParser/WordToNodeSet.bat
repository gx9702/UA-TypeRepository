@echo on
setlocal

set ROOTDIR=%~dp0
set REPODIR=X:\Work\OPC\UA-TypeRepository2
set DOCPATH=X:\Work\OPC\UA-TypeRepository2\Core\OPC UA Part 14 - PubSub Release 1.04 Specification.docx

MarkdownProcessor -word-to-nodeset -input="%DOCPATH%" -output="%REPODIR%\Core\Opc.Ua.NodeSet2.xml" -model="http://opcfoundation.org/UA/,%REPODIR%\Core\Opc.Ua.NodeSet2.xml"
