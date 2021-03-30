# Chapter 04, C# Step by Step

## Discussion Questions

1. Q: What are all possible values of *Boolean expression*?  
   A: True or False <br><br>
1. Q: List the equality operators. List the relational operators. List the logical operators. How are they the same? How are they different?  
   A: Equality operators: == (equal to), != (not equal to)  
      Relational operators: < (less than), <= (less than or equal to), >= (greater than), > (greater than or equal to)  
	  Logical operators: NOT, && (and), || (or) (in order of precedence). 
	  The logical operators are similar to the equality and relational operators in that the value of the expressions in which they appear is either true or false, but they differ in that the values on which operate must also be either true or false. <br><br>
1. Q: What is the general concept of *short circuiting*?  
   A: When the && and || operators bypass the evaluation of the right operand. For example if the left operand of the && operator evaluates false, the result of the entire expression must be false. <br><br>
1. Q: What are the differences in how *short circuiting* works for && and ||?  
   A: The && operator only short circuits if the left operand evaluates false. The || operator only short circuits if the left operand evaluates true. <br><br>
1. Q: What operator has the highest precedence? Which has the lowest?  
   A: Highest: (), Lowest: = <br><br>
1. Q: In an *if* or *else* construction using multiple lines of code, what effect does the use of curly braces have?
   A: The use of curly braces allows you to group the statments inside a block of code. <br><br>
1. Q: In a *switch* statement, what happens if you omit *break*?
   A: Execution will fall through to the next label which may lead to bugs. <br><br>
1. Q: The four keywords in a switch statement are *switch*, *case*, *break*, and *default*. Explain what each keyword does.  
   A: *Switch* statement causes control to transfer to one labeled-statement.  
      *Case* statement holds a constant-expression value that is compared to each expression.  
	  *Break* statement is used to end processing of a particular labeled statement within the *switch* statement.  
	  *Default* statement is executed if no case constant-expression value is equal to the value of the expression. <br><br>
1. Q: Look at the source listing below. It contains two methods: recurr1() and recurr2(). There is a significant difference between the two methods. What is it?  
   A: Recurr1() has one input parameter listed: int initial. Recurr2() has two input parameters listed: int product and int initial. Recurr2 has tail recurrsion. <br><br>
1. Q: What is *recursive* method? Using a language you know (such as English), write a recursive method that adds up the integers in a list of integers. The input to the method is a list of integers and the output is a scalar value representing a sum.  
   A: *Recursive* method is a method that invokes itself one or more times with different arguments. <br><br>
1. Q: Read a short summary of *De Morgan's* laws. Explain the two statements. 
   A: These two statements can be explained using logical operators and perhaps even short circuiting.