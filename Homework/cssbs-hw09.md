# Chapter 09, C# Step by Step

## Discussion Questions

1. Q: What is an *enum*?  
   A: An enum is a value type defined by a set of named constants of the underlying integral numeric type. A series of names we give to numbers.<br><br>
1. Q: Declare an enum for military ranks, either officer or enlisted. Name it Ranks. What are the symbols, like Private, Corporal, Sergeant or Lieutenant, Captain, Major?  
   A: enum Rank {Private, Corporal, Sergeant, Lieutenant, Captain, Major}<br><br>
1. Q: Using the Ranks enum, assign a rank to yourself and a friend.  
   A: Rank Scott = Rank.Private; Rank Lewis = Rank.Sergeant;<br><br>
1. Q: Determine the numeric index of particular ranks, using the Ranks enum.  
   A: enum Rank {Private = 1, Corporal = 2, Segeant = 3} Rank Brandon = (Rank)1;<br><br>
1. Q: How do you select the type of an enum?  
   A: enum Rank : short<br><br>
1. Q: What is a *struct*?  
   A: A struct is a value type that helps you make a single variable hold related data of various data types.<br><br>
1. Q: List some differences between classes and structs.  
   A: A class is a reference type defines objects or instances of a class. The object itself holds only a reference to memory on the heap where the data is stored. A struct is a value type. When a struct is created, the variable to which the struct is assigned holds the struct's actual data. When the struct is assigned to a new variable it is copied.<br><br>
1. Q: Are structs stored on the stack or on the heap? What about enums?  
   A: Both enums and structs are stored on the stack.<br><br>
1. Q: Review the documentation for the C# System.Int32struct. List the fields. List the methods.  
   A: Fields: MaxValue, MinValue. Methods: CompareTo, Equals, GetHashCode, GetTypeCode, Parse, ToString, TryFormat, TryParse.<br><br>
1. Q: Declare a struct named DOD with four branches.  
   A: struct DOD { public string Army, Navy, Marine, Airforce;<br><br>
1. Q: Why can't you create a default constructor for a struct?  
   A: Because the compiler always generates one for you.<br><br>
1. Q: What is CIL? What does the CLR do to the CIL?  
   A: CIL stands for Common Intermediate Langauge which is the machine code that the compiler converts our code into. CLR stands for Common Language Runtime which converts the CIL instructions into real machine instructions (binary) that the processor on the computer can understand and execute.<br><br>