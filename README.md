# Simple GUI
This simple "hello.cs" script creates GUI interface on Windows.  The only requirements are: Microsoft .NET Framework, and Text editor.  This was tested on Windows 10 with Microsoft .NET Framework 4.5.2 installed.


Find where the "csc.exe" is located.  Be default on Windows it is stored in "C:\Windows\Microsoft.NET\Framework64\v3.5\".  To run this command from command prompt, you either have to be in the folder, or add folder to your system $PATH:
C:\Windows\Microsoft.NET\Framework64\v3.5\

To see existing path, run this command:
echo %Path%

Modify you path to where your "hello.cs" file is stored, and where the output should be, and run this command to compile:

csc.exe /target:exe /out:c:\cs\hello.exe c:\cs\hello.cs

