@echo off
setlocal

echo Processing NodeSet Schema
xsd /classes /n:MarkdownProcessor.NodeSet UANodeSet.xsd

echo #pragma warning disable 1591 > temp.txt
type UANodeSet.cs >> temp.txt
type temp.txt > UANodeSet.cs

