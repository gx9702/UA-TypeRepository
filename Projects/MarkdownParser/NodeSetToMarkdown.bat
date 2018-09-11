@echo on
setlocal

set ROOTDIR=%~dp0
set REPODIR=X:\Work\OPC\UA-TypeRepository2

MarkdownProcessor -nodeset-to-markdown -output="%REPODIR%\Core" -model="http://opcfoundation.org/UA/,%REPODIR%\Core\Opc.Ua.NodeSet2.xml"

MarkdownProcessor -nodeset-to-markdown -output="%REPODIR%\DI" -model="http://opcfoundation.org/UA/DI/,%REPODIR%\DI\Opc.Ua.Di.NodeSet2.xml" -model="http://opcfoundation.org/UA/,%REPODIR%\Core\Opc.Ua.NodeSet2.xml"

MarkdownProcessor -nodeset-to-markdown -output="%REPODIR%\ADI" -model="http://opcfoundation.org/UA/ADI/,%REPODIR%\ADI\Opc.Ua.Adi.NodeSet2.xml" -model="http://opcfoundation.org/UA/DI/,%REPODIR%\DI\Opc.Ua.Di.NodeSet2.xml" -model="http://opcfoundation.org/UA/,%REPODIR%\Core\Opc.Ua.NodeSet2.xml"
