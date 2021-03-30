# Chapter 19, C# Step by Step

## Discussion Questions

1. Q: What is an enumerable collection?  
   A: It is a collection that implements the System.Collections.IEnumerable interface which allows you to enumerate objects within a collection.<br><br>
1. Q: What properties and methods does the IEnumerable interface contain?  
   A: The IEnumerable interface contains only a single method called GetEnumerator() which returns an enumerator that iterates through a collection.<br><br>
1. Q: What properties and methods does the IEnumerator interface contain?  
   A: The IEnumerator interface contains a single property call Current which gets the element in the collection at the current position of the enumerator. The IEnumerator also contains two methods: MoveNext() and Reset().<br><br>
1. Q: What values does the MoveNext() method return? What does it do?  
   A: MoveNext() advances the enumerator to the next element of the collection. It returns a bool.<br><br>
1. Q: What values does the Reset() method return? What does it do?  
   A: Reset() sets the enumerator to its initial position which is before the first element in the collection. It returns void.<br><br>
1. Q: Are IEnumerable and IEnumerator type safe? Why or why not? If not, how do you implement type safety?  
   A: No they exhibit a non-type safe behavior that returns an object rather than a specific type. The Microsoft .NET Framework (version 2.0 or later) provides generic interfaces that you should use to define enumerable collections.<br><br>
1. Q: Why don't recursive methods retain state when used with data structures like binary trees?  
   A: Every time you call a method you get a new stack. If using a recursive method, you create an new stack each time you call the method.<br><br>
1. Q: How do you define an enumerator?  
   A: You define an enumerator by using an iterator.<br><br>
1. Q: What is an iterator?  
   A: An iterator is a block of code that yields an ordered sequence of values.<br><br>
1. Q: What does yield do?  
   A: The yield keyword indicates the value that should be returned by each iteration.<br><br>