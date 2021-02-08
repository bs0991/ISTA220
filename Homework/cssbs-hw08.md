# Chapter 08, C# Step by Step

## Discussion Questions

1. Q: What is the difference between deep copy and shallow copy?  
   A: A deep copy is when you copy actual values of data directly to another instance of the same class. A shallow copy refers to when you only copy the reference to those fields.<br><br>
1. Q: What is the value of a reference after you declare and initialize it?  
   A: The actual value is a memory address stored on the heap.<br><br>
1. Q: How do you declare a value type?  
   A: You declare a value type by writing the type and then assigning it a name and then optionally assigning it a value. It's also good practice to declare and initialize the variable on the same line of code.<br><br>
1. Q: How do you declare a reference type?  
   A: To declare a reference type you write the class type followed by the object's name (or the instance of the class) = (assignment operator) new (keyword) followed by the constructor with the same name as the class and lastly the input parameters in parentheses.<br><br>
1. Q: Does C# allow you to assign NULL to a value type?  
   A: No, but by using the ? after the value type you can declare that the variable is a nullable value type. <br><br>
1. Q: Can you assign a nullable value type to a non-nullable variable of the same type? Why or why not?  
   A: No, because the non-nullable variable cannont contain a null without the ? modifier.<br><br>
1. Q: What is the difference between the stack and the heap?  
   A: All value types are created on the stack. All reference types are created on the heap (the reference itself is on the stack).<br><br>
1. Q: What does it mean when we say that all classes are *specialized types*?  
   A: We're saying that all classes are derived classes from the base class System.Object.<br><br>
1. Q: What does a *ref* do?  
   A: If you prefix a parameter with the *ref* keyword, the compiler generates code that passes a reference to the actual argument rather than a copy of the argument.<br><br>
1. Q: What does *out* do?  
   A: The out keyword allows the method to initialize the parameter so that the parameter becomes an alias for the argument.<br><br>
1. Q: Describe *boxing* and *unboxing* in your own words.  
   A: Boxing is when you take a value type such as int a = 5 and convert it to an object type object b = a. Unboxing is the opposite, taking an object type and converting it to a value type int c = (int)o <br><br>
1. Q: What does *cast* do?  
   A: Its the keyword used to convert one data type into a different data type.<br><br>