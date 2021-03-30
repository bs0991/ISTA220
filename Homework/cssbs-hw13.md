# Chapter 13, C# Step by Step

## Discussion Questions

1. Q: What is an interface as the term is used in object-oriented programming?  
   A: An interface is a programming structure that allows the computer to enforce certain properties on an object (class). The keyword here is enforce. Using interfaces, you can separate the "what" from the "how".<br><br>
1. Q: How do you define an interface?  
   A: Just like you define a class, but without an access modifier (public, private, or protected). Example: interface IComparable.<br><br> 
1. Q: Can an interface have variables, fields, or properties?  
   A: No.<br><br> 
1. Q: How do you define a method in an interface?  
   A: Example: interface Icomparable { int CompareTo(object obj);} The semicolon serves the purpose of declaration, not implementation of a method.<br><br> 
1. Q: Can you instantiate an object through an interface?  
   A: Yes.<br><br> 
1. Q: Using the new keyword, can you declare a reference to an interface?  
   A: No, but you can do the following. Example: Horse myHorse = new Horse(); ILandBound iMyhorse = myHorse;<br><br> 
1. Q: Can an object inherit from multiple interfaces? Can a class implement multiple interfaces? If so, how can it do so?  
   A: Yes and yes. Example: class Horse: Mammal, ILandBound, IGrazable {}. Mammal, ILandBound, and Igrazable in this case are interfaces.<br><br> 
1. Q: What does it mean to explicitely implement an interface?  
   A: To explicitely implement an interface you list the interface name before method name within that specific class. Example: Class Horse : ILandBound, IJourney { int ILandBound.NumberOfLegs(){return 4;} }<br><br> 
1. Q: What are the restrictions on interfaces?  
   A: You cannont define any fields in an interface, to include static fields.  
      You cannot define constructors in an interface.  
	  You cannot define destructors in an interface.  
	  You cannot specify an access modifier for any method. All methods in an interface are implicityly public.  
	  You cannot nest any types (enumerations, structures, classes, or interfaces) inside an interface.  
	  And an interface is not allowed to inherit from a structure or a class, but can inherit from another interface.<br><br> 
1. Q: What is the difference between an abstract class and an interface?  
   A: Within an abstract class you can implement methods or functionality. An interface only allows you to define methods or functions, not implement them.<br><br> 
1. Q: What is an abstract method?  
   A: An abstract method is used when it doesn't make sense to provide a default implementation in the abstract class, but you want to ensure that the inheriting classes provide their own implementation.<br><br> 
1. Q: What is an sealed class?  
   A: A sealed class is a class that is prevented from being used as a base class.<br><br> 
1. Q: What is a sealed method?  
   A: A sealed method is a method that a derived class cannot override.<br><br> 
