# Chapter 12, C# Step by Step

## Discussion Questions

1. Q: How does inheritance promote the principle of *don't repeat yourself (DRY)*?  
   A: Inheritance allows derived (child) classes adopt (inherit) certain attributes and behaviors. This prevents you from having to write repeatitive code for classes that share similiar attributes and behaviors.<br><br>
1. Q: What is the syntax of a derived class that inherits from a base class?  
   A: class DerivedClass : BaseClass<br><br>
1. Q: Do all user defined types (classes and structs) inherit from some base class? If so, what is it?  
   A: Yes, all structures inherit from an abstract class named System.ValueType and all classes inherit from the System.Object class.<br><br>
1. Q: What happens if you do not have a default constructor in a base class when creating a derived class?  
   A: If you do not provide a constructor, the compiler will generate a default constructor for you.<br><br>
1. Q: Can you assign a variable of a derived class to another variable of its base class? Why or why not?  
   A: Yes, because all variables within the derived class fall within the inheritance hierarchy of the base class.<br><br>
1. Q: Can you assign a variable of a derived class to another variable of a derived class of its base class? Why or why not?  
   A: No, because this violates the inheritance hierarchy.<br><br>
1. Q: Can you assign a variable of a base class to another variable of a derived class? Why or why not?  
   A: Yes, but you must first check that the variable of the base class is of the same type as the derived class. You can do this by using the *as* or *is* operator or by using a cast. This will not generate a compile error, but will generate a runtime error. <br><br>
1. Q: Under what circumstances would you want to use the *new* keyword when defining a method in a derived class?  
   A: If you absolutely want the two mehtods to have the same signature, then you can use the *new* keyword to silence the warning that addresses the potential hiding of the base classes method.<br><br>
1. Q: What is a *virtual* method? Why would you want to define a virtual method?  
   A: A *virtual method* is a method that is intended to be overridden. This can be useful when you want to implement the base class method, but need to provide more functionality within the derived class.<br><br>
1. Q: What does *override* do? Why does it do it?  
   A: The *override* keyword can be used to declare another implementation of a virtual method from a base class within the derived class.<br><br>
1. Q: How do you define an *extension type*?  
   A: You can use the keyword *this* to define extension types.<br><br>
1. Q: Why do you define an *extension type*?  
   A: You may define an *extension type* to extend an existing type with additional static methods. These static methods then become available to any statements that reference data of the type being extended.<br><br>
1. Q: Explain the *Liskov substitution principle*?  
   A: The Liskov Substitution Principle is the 3rd of Robert C. Martin's SOLID design principles: Single, Open/Closed, Liskov Substitution, Interface Segregation, Dependency Inversion. The Liskov Substitution Principle defines that objects of a superclass shall be replaceable with objects of its subclasses without breaking the application.<br><br>