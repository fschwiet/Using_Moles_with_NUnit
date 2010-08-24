I put this project out to try Microsoft Moles.  Its a dependency injection tool.  It will instrument DLLs so you can inject a test double for just about anything.  This includes static methods, extension methods, all those hard-to-isoalte dependencies.

Moles Documentation: http://research.microsoft.com/en-us/projects/pex/documentation.aspx
Moles download: http://research.microsoft.com/en-us/projects/pex/downloads.aspx

It is for Visual Studio 2010 apparently.  See the history on this repository for sample usage.  From the Visual Studio UI, you will need to right click on the "References" section of your test project, and "Add Mole assembly".

It apparently only runs from the command line, unless you use MSTest.  For this sample, I'm using NUnit on a x64 machine.