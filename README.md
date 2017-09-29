# Simple GUI
This simple "hello.cs" script creates GUI interface on Windows without any IDE installed.  This was tested on Windows 10 with Microsoft .NET Framework 4.5.2 installed.

## Requirements
* [Microsoft .NET Framework](https://www.microsoft.com/net/download/framework)
* Text editor


Find where the "csc.exe" is located.  Be default on Windows it is stored in `"C:\Windows\Microsoft.NET\Framework64\v3.5\"`.  To run this command from command prompt, you either have to be in the folder, or add folder to your system $PATH:
C:\Windows\Microsoft.NET\Framework64\v3.5\

To see existing path, run this command:
```
echo %Path%
```

If your "hello.cs" is stored on C drive in "cs" folder, then your command to compile source code into executable is:
```
csc.exe /target:exe /out:c:\cs\hello.exe c:\cs\hello.cs
```

# [![C Sharp](http://is3.mzstatic.com/image/thumb/Purple49/v4/96/ec/7b/96ec7b92-13be-1d8c-3ee5-f9d1f99a7b7b/source/1200x630bb.jpg)](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/)
