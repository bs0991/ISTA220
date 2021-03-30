1. Q: What is a console app?
	A: A console application is an application that runs in a Command Prompt window 
	instead of providing a graphical user interface (GUI).
	
2. Q: List two differences between .NET Framework and .NET Core. Note that in class, we
	will be writing C# applications in .NET Framework and ASP .NET applications in NET
	Core.
	A: The .NET Framework was designed to allow developers to build applications for a
	Windows only platform while .NET Core is cross-platform and supports multiple operating
	systems. Another difference is by application models. The .NET Framework includes Windows
	Forms, ASP.NET, and Windows Presentation Foundation (WPF) while .NET Core includes ASP.NET
	Core and Windows Universal Apps.
	
3. Q: What does Main() (the main method) do in a console application?
	A: The Main method designates the program's entry point. If the application doesn't have
	a Main method it will not run/execute.
	
4. Q: Describe these three files: TextHello.sln, TextHello.csproj, and AssemblyInfo.cs.
	A: TextHello.sln is a solution file that groups together multiple project files.
	TextHello.csproj is a project file that contains the list of files in a project as
	well as references to assemblies. AssemblyInfo.cs is a special file that can be used to
	add attributes to a program, such as the name of the author and the date the program was
	written.
	
5. Q: What is the purpose of a namespace?
	A: To help organize large libraries of classes.
	
6. Q: Describe specifcally what using statements do.
	A: The using statement (declaration) provides a clean mechanism for controlling the lifetimes of resources.
	
7. Q: What is the entry point for a console app? What is the entry point for a UWP app?
	A: The entry point for a console app is Main. In a UWP app, the App.xaml file provides
	the entry point.
	
8. Q: What is an assembly?
	A: An assembly is a collection of classes stored on the .NET Framework that take the form of
	either an executable (.exe) or dynamic link library (.dll) and are the building blocks of .NET
	applications.
	
9. Q: How many different versions of the WriteLine() method does the Console class contain?
	A: 19
	
10. Q: What is the relationship between an assembly and a namespace?
	 A: A single assembly can contain classes defined in many namespaces and a single namespace
	can span multiple assemblies. Other than this, there is no relationship between the two. 
	
11. Q: What is a graphical app?
	 A: An application that incorporates a graphical user interface with which the user can interact
	 with.

12. Q: What does Build do?
	 A: Build compiles the code or project files and components that have changed since the most
	 recent build.
	 
13. Q: What is bytecode? What is Microsoft CIL? Do you think that CIL is bytecode? Why or why not?
	 A: Bytecode is program code that has been compiled from source code into low-level code. Common
	 Intermediate Language (CIL) is the bytecode language that the just-in-time (JIT) compiler of the
	 .NET Framework interprets.
	 
14. Q: What does Debug do?
	 A: Debugging is the process of identifying and correcting potential errors in your code line by line. 
