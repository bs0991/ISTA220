# Chapter 05, C# Step by Step

## Discussion Questions

1. Q: What is the *compound assignment operator*? How does it work?  
   A: A short way to write an arithmetic expression. It's when you take any arithmetic operator and combine it with the assignment operator. var *= num is the same as var = var * num<br><br>
1. Q: List all the compound assignment operators.  
   A: *=, /=, %=, +=, -=<br><br>
1. Q: List two ways to increment a numeric variable by 5. List two ways to decrement a numeric variable by 50.  
   A: var = var +5, var += 5, var = var - 5, var -= 5<br><br>
1. Q: How long does a *while* loop run?  
   A: Until a condition is evaluated as false or until you run out of memory.<br><br>
1. Q: What is an *iteration variable*?  
   A: It's the variable that changes each time the loop executes and controls when the loop ends.<br><br>
1. Q: What happens if you don't change the loop variable in the body of the while loop block?  
   A: The loop would run forever.<br><br>
1. Q: How many parts does a *for* loop statement have? Can you omit any of them? Can you omit all of them? What happens if you omit all of them?  
   A: 3: initialization, boolean expression, update control variable. Yes. Yes. If you omit the boolean expression it defaults to true and the statement will run forever.<br><br>
1. Q: How do you guaruntee that a loop runs at least once?  
   A: Use a Do-while loop.<br><br>
1. Q: What does the *break* statement do?  
   A: Jumps out of the body of an iteration statement.<br><br>
1. Q: What does the *continue* statement do?  
   A: The continue statement causes the program to perform the next iteration of the loop immediately.<br><br>
1. Q: Can you think of any reason why you would want to have an infinite loop? An "infinte loop" is a loop without an update variable that in effect runs forever. As you will see, these kinds of loops are written intentionally to perform various kinds of tasks.  
   A: A good example of an infinite loop is a web server.<br><br>