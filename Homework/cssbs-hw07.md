# Chapter 07, C# Step by Step

## Discussion Questions

1. Q: What is a *class*? According to the book, what does a class "arrange?"  
   A: A mechanism for classifying common attributes and behaviors. A class arranges information and behavior into a meaningful entity.<br><br>
1. Q: What are the two purposes of *encapsulation*?  
   A: To combine methods and data within a class (support classification) and to control the accessibility of the methods and data (to control the use of the class)<br><br>
1. Q: How do you *instantiate* an instance of a class? How do you access that instance?  
   A: You create a new instance of a class through the *new* keyword. You access that object by assigning it a type and name and then referencing it Example Customer object = new customer(). <br><br>
1. Q: What is the default access of the fields and methods of a class? How do you change the default?  
   A: Private. You can modify the definition through the public and private keywords.<br><br>
1. Q: What is the syntax writing a *constructor*?  
   A: You first write whether the constructor is private or public then provide it with EXACTLY the same name as the class followed by () because it is a method. It can take parameters, but does not a return a value.<br><br>
1. Q: What is the difference between class fields and methods, and instance fields and methods? How do you create class fields and methods?  
   A: Class fields and methods are variables and behavior defined within the base class using the static keyword. They're often referred to as "Class Members". Instance fields and methods can only be accessed through the objects themselves.<br>
1. Q: How do you bring a static class in scope? Why would you want to bring a static class in scope?  
   A: You bring a static class into scope by using the name of the class.<br><br>
1. Q: Can you think of a good reason to create an *anonymous class*? What is it?  
   A: An anonymous class is a class that does not have a name. They can be used to create objects even if you don't know what the type will be.<br><br>
1. Q: What is a *polymorphism* as this term is used in computer science?  
   A: Polymorphism is the provision of a single interface to entities of different types or the use of a single symbol to represent multiple different types.<br><br>
1. Q: What is *message passing* as this term is used in computer science?  
   A: Message passing is a technique for invoking behavior on a computer. This is how OOP programs operate.<br><br>
1. Q: What was the first object-oriented programming language?  
   A: Simula (1967).<br><br>
1. Q: Consider this quote by Alexander Stepanov:
I find OOP technically unsound. It attempts to decompose the world in terms of interfaces
that vary on a single type. To deal with the real problems you need multisorted algebras
— families of interfaces that span multiple types. I find OOP philosophically unsound. It
claims that everything is an object. Even if it is true it is not very interesting — saying that
everything is an object is saying nothing at all. Who is Alexander Stephanov? What do you think about this quote? <br><br>
   A: Alexandar Stephanov is a Russian-American computer programmer best known as an advocate of generic programming and as the primary designer and implementer of the C++ standard template library. He describes OOP as something that trys to define the world in black and white terms. I think he makes the argument that the world is much more dynamic than that and it is impossible to define the world in that way.<br><br>