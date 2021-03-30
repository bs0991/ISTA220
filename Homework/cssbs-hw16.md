# Chapter 16, C# Step by Step

## Discussion Questions

1. Q: Give five examples (using valid C# code) of the five bitwise operators listed in the text.  
   A: int A = 60, int B = 13
	* NOT (~) -> (~A)
	* Left-Shift (<<) -> (A<<2)
	* Right-Shift (>>) -> (A>>2)
	* OR (|) -> (A|B)
	* AND (&) -> (A&B)
	* XOR (A^B)<br><br>
1. Q: Does C# implement the right-shift (>>) operator? If so, give an example of its operation using valid C# code.  
   A: Yes, (A>>2) = 15<br><br>
1. Q: Explain in detail this code: bits & (1 << index)  
   A: In binary, the 1 (00000001 as a byte) is shifted to the left however many times according to the value of the index. The & operator then returns a value where both the variable bits and the new 8 bit expression contain a 1 in the same position.<br><br>
1. Q: Explain in detail this code: bits |= (1 << index)  
   A: 1 (00000001) is shifted to the left (index) times. The OR assignment (|=) operator is used to assign a new value to the variable bits, returning a value containing a 1 in each position in which either operands has a 1.<br><br>
1. Q: Explain in detail this code: bits &= (1 << index)  
   A: Same as question number three, but in this case that new value is assigned to the variable bits.<br><br>
1. Q: How does C# interpret this? bool peek = bits[n]  
   A: It retrieves the bool at index n. This statement is converted to a call to the get accessor for bits, and the index argument is set to n.<br><br>
1. Q: How does C# interpret this? bits[n] = true;  
   A: Sets the bit at index n to true. When you write to an indexer, the compiler automatically translates this code into a call to the set accessor of that indexer, setting the index argument to the value (n) enclosed in the square brackets.<br><br>
1. Q: How does C# interpret this? bits[n] ^= true  
   A: In this context both the get and set accessors are used. The XOR operator is used to invert the value of the bit at index [n].<br><br>
1. Q: Assume that users were assigned read, write, and execute permissions according to this scheme: read = 1, write = 2, execute = 4. How would you interpret the following user permissions:
	* permission = 0
	* permission = 1
	* permission = 2
	* permission = 3
	* permission = 4
	* permission = 5
	* permission = 6
	* permission = 7  <br><br>
   A: <br><br>
1. Q: Answer the previous question by converting the decimal permissions into binary permissions. What does this tell you about using this scheme of permissions?  
   A: 