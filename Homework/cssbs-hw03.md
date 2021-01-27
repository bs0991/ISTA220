 # Chapter 03, C# Step by Step
 
 ## Discussion Questions
 
 1. Q: What is a *method*?  
    A: A method is a named block of code that optionally accepts input and returns output. <br><br>
 1. Q: (Not in book) What is the difference between a *function* and a *procedure/subprocedure/subroutine*?  
    A: A *function* is a named block of code (black box) that takes input and performs certain tasks, returning a value. A *procedure* is similar to a statement in that it takes an action and performs certain tasks, but does not return a value. <br><br>
 1. Q: What does a *return* statement do?  
    A: A *return* statement ends the execution of a function and returns control to the calling function. A *return* statement can return a value to the calling function, unless the *return type* is void. <br><br>
 1. Q: What is an *expression bodied* method?  
    A: An expression bodied method consists of a single expression that returns a value whos type matches the method's return type, or, for methods that return void, that performs some operation. <br><br>
 1. Q: What is the *scope* of a variable?  
    A: The region of the program in which that variable is usable. <br><br>
 1. Q: What is a *field*?  
    A: A *field* is a variable of any type that is declared directly in a class or struct. Fields are *members* of their containing type. <br><br>
 1. Q: What is an *overloaded* method?  
    A: A feature that allows multiple methods to have the same name with different parameters (type). <br><br>
 1. Q: How do you call a method that requires *arguments*?  
    A: You specify the method name and provide the necessary arguments inside the parameter list. <br><br>
 1. Q: How do you write a method, that is, specify the method definition, that requires a *parameter list*?
    A: Write the method within a class. Specify the type of the method, name of method, parameter list, and return type, followed by the body of the method between braces. Return type, name of method, parameter list, body of method. <br><br>
 1. Q: How do you specify a parameter as optional when defining a method?
    A: You write the parameters the same and call the method the same. Any parameter can be optional if it is not provided. Example is substrg(X,Y,Z) and we only use X and Y. <br><br>
 1. Q: How do you pass an argument to a method as a *named parameter*?
    A: To pass an argument as a *named parameter* you specify the name of the parameter, followed by a colon and the value to use. <br><br>
 1. Q: How do you return values from a method? Can you return multiple values from a method, and if so, how?  
    A: You declare a methods return type in its method declaration. Within the body of the method you use the *return* statement to return the value. Any method declared *void* does not return a value and cannot contain a *return* statement. Yes, by returning a tuple. <br><br>
 1. Q: What is a *tuple*?  How do you define a method that returns multiple values? Give an example of a method that returns multiple values other than the example in the book.  
    A: A *tuple* is a small collection of values. You indicate that a method returns a *tuple* by specifying a list of types as part of the method definition; one type for each value returned. <br><br>
 1. Q: Examine the method definition on page 83 of the book. Desk check the execution of this method. What do you discover? This is called *recursion*.
    A: A function is defined and then called within itself. <br><br>
 1. Q: How does the compiler resolve an ambiguity between named arguments and optional parameters?  
    A: It doesn't. Its an unresolvable ambiguity, and the compiler does not let you compile the application. <br><br>
 1. Q: The book states: "A key feature of C# and other languages designed for the .NET Framework is the ability to interoperate with applications and components written with other technologies." What is the COM and how is the CLR dependent on the COM?
    A: COM stands for Component Object Model. <br><br>