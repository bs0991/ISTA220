# Chapter 20, C# Step by Step

## Discussion Questions

1. Q: What is a delegate? Explain delegates in terms of pointers and reference types.  
   A: A delegate can be a type or an object that refers to a method. You can assign a reference to a method to a delegate the same way you can assign an in value to an int variable.<br><br>
1. Q: How do you declare a delegate? Include a discussion of types, return values, names, and parameters?  
   A: You declare a delegate using the "delegate" keyword. Example: "public delegate void methodnameDelegate();"<br><br>
1. Q: How do you create instances of delegates and assign values to the instance?  What are the values?  
   A: You can create an instance of a delegate by using the delegate method as the type followed by the instance name. Example: "methodnameDelegate objectName;". To assign a value to this instance you can use the "+=" compound assignment operator to refer to a method who's signature matches that of the delegates.<br><br>
1. Q: How do you invoke a method that has been added to a delegate?  
   A: You invoke the delegate the same way you would call a normal method. You list the name of the delegate instance followed by (). Example: "objectName();".<br><br>
1. Q: What is an event? Why do we have events?  
   A: An event is simply something that happens in the environment. Events enable a class or object to notify other classes or objects when something of interest occurs. An event can be used to define and trap siginificant actions and arrange for a delegate to be called to handle the situation automatically.<br><br>
1. Q: How do you declare events?  
   A: You declare an event similar to how you would declare a field. However, the type of an event must be a delegate, and you must prefix the declaration with the "event" keyword. Example: "event delegateTypeName eventName"<br><br>
1. Q: How do delegates recognize event subscriptions? How do you unsubscribe an event from a delegate?  
   A: You subscribe to an event by using the += operator. To unsubscribe from an event you use the -= operator.<br><br>
1. Q: How do you raise an event? How do you declare code that raises an event?  
   A: You can raise an event by calling it like a method. Example: "eventName ();". You can declare code that raises an event by using an if statement to check whether the event is null.<br><br>
1. Q: Explain with specificity what happens when an event fires and that event has been attached to a delegate?  
   A: It calls all of the methods that the event is subscribed to.<br><br>