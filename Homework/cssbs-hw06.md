# Chapter 06, C# Step by Step

## Discussion Questions

1. Q: What is an *exception*?  
   A: An exception is a problem that arises during the execution of a program.<br><br>
1. Q: What happens in a *try* block if the program executes without errors?  
   A: A try block identifies a block of code for which particular exceptions is activated. Without an exception the program will exectute as normal.<br><br>
1. Q: How does the *catch* mechanism work for unhandled exceptions?  
   A: The exeception is still thrown to the first catch handler after the try block. If that exception is not caught by the catch handler then the execution will return to the calling method to attempt to locate another try block or matching catch handler. It will repeat this process until it finds a matching catch handler and if not then the program will terminate.<br><br>
1. Q: What happens in a program if an *exception block* fails to handle an particular error?  
   A: See answer to #3.<br><br>
1. Q: What is the parent class for all exceptions? How does this work?  
   A: SystemException or just Exception<br><br>
1. Q: How do you determine the type of an error?  
   A: The type of error will be displayed with a description highlighting the error itself. This will happen when using the exception.message property.<br><br>
1. Q: What is the purpose of integer checking?  
   A: To ensure an OverflowException is always thrown.<br><br>
1. Q: What is the range of values than a signed Int32 type can contain? State the lowest value and the highest value.  
   A: int MinValue (-2147483648) to int MaxValue (2147483647)<br><br>
1. Q: What is the range of values than an *unsigned* Int32 type can contain? State the lowest value and the highest value. What is the difference between a signed integer and an unsigned integer? Can signed integers and unsigned integers represent the same amount of numbers?  
   A: 0 to 4294967295. An unsigned integer does not contain negative numbers. It's range of values is 0 - 4294967295. A signed integer can contain negative integers. Its range of values is -2147483648 - 2147483647.<br><br>
1. Q: What does the *finally* block do?  
   A: A finally block is used after a try block or immediately after the last catch handler to ensure critical code always runs even if an exception occurs.<br><br>
1. Q: (Thought question) When would you not use a finally block in a try/catch construction?  
   A: Whenever you don't want the code to run if an exception occurs.<br><br>