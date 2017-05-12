# SampleProject
Sample Project

# Bug
Microsoft.VisualStudio.Web.CodeGenerators package loads a bad version of MEF assembly for framework .NETCoreApp 1.1.
At the runtime I Get the error below :
```
FileNotFoundException: Could not load file or assembly 
'System.Composition.TypedParts, Version=1.0.31.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'. 
The system cannot find the file specified.
```
