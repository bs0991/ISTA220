# Chapter 17, C# Step by Step

## Discussion Questions

1. Q: What is a type parameter?  
   A: A type parameter is a placeholder for a specific type that a client specifies when they create an instance of the generic type.<br><br>
1. Q: What does a type parameter do?  
   A: Type parameters specify the types of objects on which they operate.<br><br>
1. Q: How many type parameters can a generic class have?  
   A: As many as necessary.<br><br>
1. Q: What is the difference between a generic class and a generalized class?  
   A: With a generalized class there is a single implementation of the class itself and its methods. With a generic class you cause the compiler to generate an entirely new class each time you use it with a type parameter.<br><br>
1. Q: What is a constraint? How do you specify a constraint?  
   A: Constraints inform the compiler about the capabilities a type argument must have. To specify a constraint you use the where keyword.<br><br>
1. Q: What is a generic method? How do you define a generic method?  
   A: With a generic method, you can specify the types of the parameters and the return type by using a type parameter. You define generic methods by using the same type parameter syntax you use when you create generic classes.<br><br>
1. Q: What do we mean when we say that a generic type interface is invariant?  
   A: Invariance means that you can use only the type originally specified. An invariant generic type parameter is neither covariant nor contravariant.<br><br>
1. Q: What do we mean when we say that a generic type interface is covariant?  
   A: Covariance enables you to use a more derived type than originally specified.<br><br>
1. Q: Does covariance work with value types? Does it work with reference types?  
   A: Covariance works only with reference types.<br><br>
1. Q: What do we mean when we say that a generic type interface is contravariant?  
   A: Contravariance enables you to use a more generic (less derived) type than orginally specified.<br><br>