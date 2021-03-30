# Chapter 18, C# Step by Step

## Discussion Questions

1. Q: You are building a help ticket system. You want to ensure that the older the ticket, the sooner it will be handled by the team. For example, a ticket submitted a week ago has a higher priority than a
ticked just submitted. What kind of data structure would you use, and why?  
   A: In this case you would want to implement a Queue, becuase it utilizes a first-in, first-out approach.<br><br>
1. Q: You are building a tracking system for seasonal agricultural farm labor. The labor requirements vary widely, depending on the season. Your requirement is that the newest hires are terminated first, and that our more experienced hires are kept longer. What kind of data structure would you use, and why?  
   A: In this case I would utilize a Stack, becuase it utilizes a first-in, last-out approach.<br><br>
1. Q: You are building a transaction database. Your requirement is that the database adds data very quickly, and that deletions, updates, and searches happen infrequently. In other words, data is typically added in the order in which the transaction occurs. What kind of data structure would you use, and why?  
   A: In this case I would use a List since we want to add data quickly, but deletions and updates happen infrequently.<br><br>
1. Q: You are building an analytical database. Your requirement is that the database handle queries very
quickly, but that the data never changes, i.e., there are no inserts, deletions, or updates. What kind
of data structure would you use, and why?  
   A: In this case I would use a HashSet, because we want to retrieve data quickly, but are not concerned with manipulating or retrieving data.<br><br>
1. Q: You are building a personnel directory, where searched are performed by last name, first name, middle name. What kind of data structure would you use, and why?  
   A: I would utilize a SortedList in this case, becuase typically you would want names to be sorted in alphabetical order and you can retrieve the names using key/value pairs.<br><br>
1. Q: You are building a username/password database. Your requirement is that updates happen frequently
(when users change their passwords) and that searches (to authenticate users) happenb extremely
quickly. What kind of data structure would you use, and why?  
   A: In this case I would use a dictionary to quickly access data. <br><br>
1. Q: What is a lambda expression? Give an example. Why would we use a lambda expression?  
   A: A lambda expression is an expression that returns a method.<br><br>
1. Q: What is the difference between lambda expressions and anonymous methods? What are the advantages
of each?  
   A: Lambda expressions were built off of anonymous expressions. An anonymous method is still, however, a method. A lambda expression carries out the instructions inside the stack that you are currently in.<br><br>
   



