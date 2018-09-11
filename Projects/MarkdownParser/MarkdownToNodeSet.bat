@echo on
setlocal

set ROOTDIR=%~dp0
set REPODIR=X:\Work\OPC\UA-TypeRepository2

MarkdownProcessor -markdown-to-nodeset -output="%REPODIR%\Core\Opc.Ua.NodeSet2.xml" -model="http://opcfoundation.org/UA/,%REPODIR%\Core\Opc.Ua.NodeSet2.xml"
