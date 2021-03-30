# Chapter 15, C# Step by Step

## Discussion Questions

1. Q: What is the difference between a *property* and a *field*?  
   A: A field is a variable of any type that is declared directly in a class or struct. A property is a member that provides a secure way to read and write the values associated with a private field.<br><br>
1. Q: What is the difference between a *property* and a *method*?  
   A: In general, a property represents data and a method represents actions.<br><br>
1. Q: What is your understanding of *encapsulation*?  
   A: Encapsulation means that a group of related properties or methods are treated as a single unit or object.<br><br>
1. Q: Some languages are case insensitive, that is, an ‘a” and an “A” are considered to be the same letter.
C# is case sensitive. What implications does this have regarding the naming of variables, methods,
and other identifiers? Do you think that the difference in case in the initial character of two different
identifiers is sufficient to distinguish them?  
   A: No, use an underscore instead distinguish private fields from public properties.<br><br>
1. Q: Give an example that is not in the book of an instance where you might want to use a read-only property. Give an example not in the book of an instance where you might want to use a write-only property.  
   A: One example of a read-only property would be accessing a serial number of a weapon. A good example of a write-only property would be writing your password.<br><br>
1. Q: Can you think of a reason why you might ever want to make getters and setters private? Give an example. Also, make a case why getters and setters should never be private.  
   A: One reason would be so your password is never displayed. And a case why getters and setters should never be private is in any case where the user needs to read/write values (calculator?).<br><br>
1. Q: What are restrictions on the use of properties?  
   A: You can assign a value through a property of a struct or class only after the struct or class has been initialized. You cannot use a property as a ref or an out argument to a method. A property cannot containe other methods, fields, or properties. The get/set accessors cannot take any parameters. You can't declare properties by using const.<br><br>
1. Q: What is an *object initializer*? What is the syntax for an object initializer?  
   A: Object initializers let you assign values to any accessible fields or properties of an object at creation time without having to invoke a constructor followed by lines of assignment statements. Example: Cat cat = new Cat {Age=10, Name="Fluffy"};<br><br>