# Chapter 02, C# Step by Step

## Discussion Questions

1. Q: **What is a *local* variable?**  
   A: A local variable is a variable that is used within the method in which it is declared. They can only be used by statements that are inside that function or block of code.<br><br>
1. Q: **What is a *statement*?**  
   A: A statement is a command that performs an action, such as calculating a value and storing the result or displaying a message to a user.<br><br>
1. Q: **What is an *identifier*?**  
   A: Identifiers are the names that you use to identify the elements in your programs, such as namespaces, classes, methods, and variables.<br><br>
1. Q: **What is a *keyword*?**  
   A: Keywords are predefined, reserved identifiers that have special meanings to the compiler. They cannot be used as identifiers in your program unless they include @ as a prefix.<br><br>
1. Q: **What is a *variable*?**  
   A: A variable is a storage location that holds a value. Mr. Carter's definition of a variable is this: A variable is a name location in memory that may contain a value.<br><br>
1. Q: **How do you declare a variable? How do you assign a value to a variable? Can you have a variable that does not have a value? Can you declare and initialize a variable in a single statement?**  
   A: To declare a variable you declare the type and the name of the variable in a declaration statement. To assign a value to a variable you use the assignment operator (=) and write the value to the right of the equal sign. A variable does not have to have a value unless you use that variable, but must have a type and yes you can declare and initialize a variable in a single statement.<br><br>
1. Q: **What does Visual Studio do when you open a project (a .csproj file) without opening the solution (a .sln file)? Why might this be a problem?**  
   A: If you open a project rather than a solution, Visual Studio 2017 automatically creates a new solution file for it. This can result in you accidentally generating multiple solutions for the same project.<br><br>
1. Q: **How are arithmetic operators and variable types related?**  
   A: Arithmetic operators can be used used to manipulate different variable types to include type char, int, long, float, double, decimal and even string. The meaning of the arithmetic operator depends on the variable type.<br><br>
1. Q: **How do you turn an integer into a string?**  
   A: To generate a string representation of an integer you call the ToString method.<br><br>
1. Q: **How do you turn a string into an integer?**  
   A: To convert a string into an integer call the System.Int32.Parse method.<br><br>
1. Q: **What is the difference between precedence and associativity? Give an example where this makes a difference.**  
   A: Precedence (vertical application, up or down) governs the order in which an expressions's operators are evaluated. Associativity (horizontal application, left or right) is the direction in which the operands of an operator are evaluated.<br><br>
1. Q: **What is the *definite assignment rule*?**  
   A: The definite assignment rule is a feature in C# that does not allow us to use an unassigned variable.<br><br>
1. Q: **How are the prefix and postfix increment and decrement operators evaluated differently?**  
   A: They're not. Whether you use the prefix or postfix form of the ++ or -- operators makes no difference to the variable being incremented or decremented.<br><br>
1. Q: **What is *string interpolation*?**  
   A: String interpolation is a method concatenating, formatting and manipulating strings. Using the $ symbol at the start of the string indicates that it is an interpolated string and that any expressions between the curly brackets should be evaluated and the result substituted in their place.<br><br>
1. Q: **What does the *var* keyword do?**  
   A: The var keyword causes the compiler to deduce the type of the variables from the types of the expressions used to initialize them.<br><br>
