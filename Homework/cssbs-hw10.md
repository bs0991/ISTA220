# Chapter 10, C# Step by Step

## Discussion Questions

1. Q: What does an array look like in memory?  
   A: When you first declare an array that reference is stored on the stack. Just as a class, when you create a new instance of an array that continous block of memory is allocated from the heap. It being a single block of memory is the reason for why arrays are so fast.<br><br>
1. Q: Where is memory allocated to hold an array, on the stack or on the heap?  
   A: After you create an instance of an array, memory is allocated on the heap to hold an array regardless of the type of it's elements. It is stored on the heap due to size. The stack cannot hold all of the potential elements associated with an array.<br><br>
1. Q: Where is memory allocated to hold an array reference, on the stack or on the heap?  
   A: An array reference is stored on the stack.<br><br>
1. Q: Can an array hold values of different types? What determines the types that an array can hold?  
   A: Arrays themselves can contain any type of element value based off of what we define it as. However, you cannot store different types within a single array. In some cases, the compiler will convert elements to a different type, but generally it's best to avoid mixing types.<br><br>
1. Q: Describe the syntax of the condition for a *foreach* loop.  
   A: int[] pins = {9, 3, 7, 2}; for each (int pin in pins) {  Console.WriteLine(pin)  }<br><br>
1. Q: How do you make a deep copy of an array?  
   A: In order to make a deep copy you must iterate through each element using a for loop and assign each element value to the new variable.<br><br>
1. Q: What is the difference in the syntax between a multi-dimensional array and an array of arrays?  
   A: Multi-dimensional array: int[,]items = new int[4,6]; Array of arrays: int[][]items = new int [4][3];  <br><br>
1. Q: What is the difference in the uses for a multi-dimensional array and an array of arrays? In other words, what determines whether you would use one as opposed to the other?  
   A: Multi-dimensional arrays take up alot of memory space. An array of arrays simply copies references and does not copy data, which makes it more conservative with memory.<br><br>
1. Q: How do you "flatten" a multidimensional array?  
   A: Use a nested for loop to iterate through and copy the data to a new element listing like we mentioned in question #6.<br><br>
1. Q: When we use a for loop, we can change the values of the array elements inside the loop. When we use a foreach loop, we cannot change the values of the array elements inside the loop. Why not? How is for different from foreach?  
   A: The iteration variable of the foreach statement is a read-only copy of each element of the array. A foreach statement always iterates through the entire array and always starts from index 0. Using a for statement you can start the iteration where you'd like as well as iterate backwards.<br><br>
  
   