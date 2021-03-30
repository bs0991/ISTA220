# Chapter 11, C# Step by Step

## Discussion Questions

1. Q: What is a *parameter array*?  
   A: An array that is automatically created by the compiler when an arbitrary number of argurments are passed to a method. When you need an indefinite number of arguments, you can declare a *parameter array*, which allows a procedure to accept an array of values for a parameter. <br><br>
1. Q: How do you define a method that takes an arbitrary number of arguments?  
   A: Use the params keyword when defining the input parameters. Example: public static int Min(params int [] paramList)<br><br>
1. Q: How do you call a method that takes an arbitrary number of arguments to a method?  
   A: You call the method as normal. Example: int min = Util.Min(first, second); This allows you to call the method by using any number of integer arguments without worrying agbout creating an array.<br><br>
1. Q: Why can't you use an array to pass an arbitrary number of arguments to a method?  
   A: Because when declaring an array you must specify it's length, unless you indicate that the array is a parameter array using the params keyword.<br><br>
1. Q: How many parameters can a method have?  
   A: There is no standard limit.<br><br>
1. Q: Do parameter arguments have to have the same type?  
   A: No.<br><br>
1. Q: What is the difference between a method that takes a parameter argument and one that takes optional arguments?  
   A: A method that takes optional parameters still has a fi xed parameter list, and you cannot pass an arbitrary list of arguments. A method that uses a parameter array effectively has a completely arbitrary list of parameters, and none of them has a default value.<br><br>
1. Q: How do you define a method that takes different (and arbitrary) types of arguments?  
   A: Use the params keyword along with 'object'. All types are considered objects.<br><br>
1. Q: Write a method that accepts any number of arguments of a given type.  
   A: someType Method(params bool[] flags)<br><br>
1. Q: Write a method that accepts any number of arguments of any type.  
   A: someType Method(params object[] paramList)<br><br>